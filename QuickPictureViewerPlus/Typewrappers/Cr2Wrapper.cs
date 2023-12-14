using QuickLibrary;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace QuickPictureViewerPlus
{
	public class Cr2Wrapper : TypeWrapper
	{
		private static int _bufferSize = 512 * 1024;
		private static ImageCodecInfo _jpgImageCodec = GetJpegCodec();

        public Cr2Wrapper()
        {
            TypeName = "CR2";
            ShowTypeOps = false;
        }

        public override FileTypeMan.OpenResult Open(string path) 
        {
            try
            {
                string tempJpg = ConvertImage(path);
                if (tempJpg == null)
                {
                    return new FileTypeMan.OpenResult
                    {
                        ErrorMessage = TypeName + " - " + LangMan.Get("unable-open-file") + ": " + Path.GetFileName(path)
                    };
                }
                else
                {
                    return new FileTypeMan.OpenResult
                    {
                        Bmp = new Bitmap(tempJpg)
                    };
                }
            }
            catch
            {
                return new FileTypeMan.OpenResult
                {
                    ErrorMessage = TypeName + " - " + LangMan.Get("unable-open-file") + ": " + Path.GetFileName(path)
                };
            }
        }

		private static string ConvertImage(string path)
		{
			using (FileStream fi = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite, _bufferSize, FileOptions.None))
			{
				// Start address is at offset 0x62, file size at 0x7A, orientation at 0x6E
				fi.Seek(0x62, SeekOrigin.Begin);
				BinaryReader br = new BinaryReader(fi);
				UInt32 jpgStartPosition = br.ReadUInt32();  // 62
				br.ReadUInt32();  // 66
				br.ReadUInt32();  // 6A
				UInt32 orientation = br.ReadUInt32() & 0x000000FF; // 6E
				br.ReadUInt32();  // 72
				br.ReadUInt32();  // 76
				Int32 fileSize = br.ReadInt32();  // 7A

				fi.Seek(jpgStartPosition, SeekOrigin.Begin);

				string baseName = Path.GetFileNameWithoutExtension(path);
                using (Bitmap bitmap = new Bitmap(new PartialStream(fi, jpgStartPosition, fileSize))) 
                {
                    try
                    {
                        if (_jpgImageCodec != null && (orientation == 8 || orientation == 6))
                        {
                            if (orientation == 8) bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                            else bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        }
                    }
                    catch
                    {

                    }

                    int freeIndex = 0;
                    string freePath = "qpv-cr2-";
                    string tempPath = Path.Combine(Path.GetTempPath(), freePath + freeIndex + ".jpg");
                    while (File.Exists(tempPath))
					{
                        try
                        {
                            File.Delete(tempPath);
                        }
                        catch
						{
                            freeIndex++;
                            tempPath = Path.Combine(Path.GetTempPath(), freePath + freeIndex + ".jpg");
                        }
                    }

                    EncoderParameters ep = new EncoderParameters(1);
                    ep.Param[0] = new EncoderParameter(Encoder.Quality, 100L);
                    bitmap.Save(tempPath, _jpgImageCodec, ep);

                    return tempPath;
                }
			}
		}

		private static ImageCodecInfo GetJpegCodec()
		{
			foreach (ImageCodecInfo c in ImageCodecInfo.GetImageEncoders())
			{
				if (c.CodecName.ToLower().Contains("jpeg")
					|| c.FilenameExtension.ToLower().Contains("*.jpg")
					|| c.FormatDescription.ToLower().Contains("jpeg")
					|| c.MimeType.ToLower().Contains("image/jpeg"))
					return c;
			}

			return null;
		}
	}

    internal class PartialStream : Stream
    {
        private FileStream m_f;

        private int m_length;
        private uint m_start;

        internal PartialStream(FileStream p_f, uint p_start, int p_length)
        {
            m_f = p_f;
            m_start = p_start;
            m_length = p_length;

            m_f.Seek(p_start, SeekOrigin.Begin);
        }

        public override bool CanRead
        {
            get { return m_f.CanRead; }
        }

        public override bool CanSeek
        {
            get { return m_f.CanSeek; }
        }

        public override bool CanTimeout
        {
            get { return m_f.CanTimeout; }
        }

        public override bool CanWrite
        {
            get { return m_f.CanWrite; }
        }

        public override long Length
        {
            get { return m_length; }
        }

        public override long Position
        {
            get { return m_f.Position - m_start; }
            set { m_f.Position = value + m_start; }
        }

        public override int ReadTimeout
        {
            get { return m_f.ReadTimeout; }
            set { m_f.ReadTimeout = value; }
        }

        public override int WriteTimeout
        {
            get { return m_f.WriteTimeout; }
            set { m_f.WriteTimeout = value; }
        }

        public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
            return m_f.BeginRead(buffer, offset, count, callback, state);
        }

        public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
            return m_f.BeginWrite(buffer, offset, count, callback, state);
        }

        public override void Close()
        {
            m_f.Close();
        }

        public override int EndRead(IAsyncResult asyncResult)
        {
            return m_f.EndRead(asyncResult);
        }

        public override void EndWrite(IAsyncResult asyncResult)
        {
            m_f.EndWrite(asyncResult);
        }

        public override bool Equals(object obj)
        {
            return m_f.Equals(obj);
        }

        public override void Flush()
        {
            m_f.Flush();
        }

        public override int GetHashCode()
        {
            return m_f.GetHashCode();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            long maxRead = Length - Position;
            return m_f.Read(buffer, offset, (count <= maxRead) ? count : (int)maxRead);
        }

        public override int ReadByte()
        {
            if (Position < Length) return m_f.ReadByte();
            else return 0;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return m_f.Seek(offset + m_start, origin);
        }

        public override void SetLength(long value)
        {
            m_f.SetLength(value);
        }

        public override string ToString()
        {
            return m_f.ToString();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            m_f.Write(buffer, offset, count);
        }

        public override void WriteByte(byte value)
        {
            m_f.WriteByte(value);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
