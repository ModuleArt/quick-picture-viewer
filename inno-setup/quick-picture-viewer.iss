#define MyAppName "Quick Picture Viewer"
#define MyAppVersion "3.1.4"
#define MyAppPublisher "Module Art"
#define MyAppURL "https://moduleart.github.io/quick-picture-viewer"
#define MyAppExeName "quick-picture-viewer.exe"

[Setup]
AppId={{F102E394-0FA6-4AEA-826D-9FE699115BAB}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\QuickPictureViewer
DisableProgramGroupPage=yes
LicenseFile=D:\Projects\quick-picture-viewer\LICENSE
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputDir=D:\Projects\quick-picture-viewer\inno-setup
OutputBaseFilename=QuickPictureViewer-Setup
SetupIconFile=D:\Projects\quick-picture-viewer\quick-picture-viewer\resources\imgs\picture.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern
UninstallDisplayIcon={app}\{#MyAppExeName}
UninstallDisplayName={#MyAppName}
WizardImageFile=WizardImageFile.bmp
WizardSmallImageFile=WizardSmallImageFile.bmp
ChangesAssociations=yes
VersionInfoVersion={#MyAppVersion}

[Messages]
SetupWindowTitle=Setup - {#MyAppName} v{#MyAppVersion}
SetupAppTitle=Setup - {#MyAppName} v{#MyAppVersion}

[Languages]
Name: "en"; MessagesFile: "compiler:Default.isl"
Name: "chinesesimplified"; MessagesFile: "compiler:Languages\ChineseSimplified.isl"
Name: "cr"; MessagesFile: "compiler:Languages\Croatian.isl"
Name: "de"; MessagesFile: "compiler:Languages\German.isl"
Name: "es"; MessagesFile: "compiler:Languages\Spanish.isl"
Name: "fr"; MessagesFile: "compiler:Languages\French.isl"
Name: "hu"; MessagesFile: "compiler:Languages\Hungarian.isl"
Name: "ru"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "openwith"; Description: "Open with {#MyAppName}"; GroupDescription: "Context menu:"; Flags: checkedonce
Name: "browsefolder"; Description: "Browse folder with {#MyAppName}"; GroupDescription: "Context menu:"; Flags: checkedonce

[Files]
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\bin\Release\quick-picture-viewer.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\bin\Release\QuickLibrary.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\bin\Release\quick-picture-viewer.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\bin\Release\quick-picture-viewer.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\resources\quick-picture-viewer.VisualElementsManifest.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\resources\imgs\picture.ico"; DestDir: "{app}"; Flags: ignoreversion
; Local libraries
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\resources\dlls\libwebp_x64.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\resources\dlls\libwebp_x86.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\resources\dlls\SimplePsd.dll"; DestDir: "{app}"; Flags: ignoreversion
; Nuget libraries
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\bin\Release\QuickLibrary.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\bin\Release\Octokit.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\bin\Release\Utf8Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\bin\Release\Pfim.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\bin\Release\Svg.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\bin\Release\Microsoft.WindowsAPICodePack.dll"; DestDir: "{app}"; Flags: ignoreversion
; Dependencies
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\bin\Release\Fizzler.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\bin\Release\Microsoft.WindowsAPICodePack.Shell.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\bin\Release\System.Buffers.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\bin\Release\System.Memory.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\bin\Release\System.Numerics.Vectors.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\bin\Release\System.Runtime.CompilerServices.Unsafe.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\bin\Release\System.ValueTuple.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\bin\Release\System.Threading.Tasks.Extensions.dll"; DestDir: "{app}"; Flags: ignoreversion
; Place plugins from Debug folder
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\bin\Debug\plugins\*"; DestDir: "{app}\plugins"; Flags: ignoreversion recursesubdirs
; Ico files for different formats
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\resources\imgs\file-types\bmp.ico"; DestDir: "{app}\icons"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\resources\imgs\file-types\dds.ico"; DestDir: "{app}\icons"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\resources\imgs\file-types\dib.ico"; DestDir: "{app}\icons"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\resources\imgs\file-types\exif.ico"; DestDir: "{app}\icons"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\resources\imgs\file-types\gif.ico"; DestDir: "{app}\icons"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\resources\imgs\file-types\jfif.ico"; DestDir: "{app}\icons"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\resources\imgs\file-types\jpg.ico"; DestDir: "{app}\icons"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\resources\imgs\file-types\png.ico"; DestDir: "{app}\icons"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\resources\imgs\file-types\rle.ico"; DestDir: "{app}\icons"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\resources\imgs\file-types\svg.ico"; DestDir: "{app}\icons"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\resources\imgs\file-types\tga.ico"; DestDir: "{app}\icons"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\resources\imgs\file-types\tif.ico"; DestDir: "{app}\icons"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\resources\imgs\file-types\webp.ico"; DestDir: "{app}\icons"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\resources\imgs\file-types\psd.ico"; DestDir: "{app}\icons"; Flags: ignoreversion
Source: "D:\Projects\quick-picture-viewer\quick-picture-viewer\resources\imgs\file-types\cr2.ico"; DestDir: "{app}\icons"; Flags: ignoreversion

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[Registry]
; Register software
Root: HKCU; Subkey: "Software\RegisteredApplications"; ValueType: string; ValueName: "QuickPictureViewer"; ValueData: "Software\Clients\StartMenuInternet\QuickPictureViewer\Capabilities"; Flags: uninsdeletekey
; Open with QuickPictureViewer
Root: HKCR; Subkey: "*\shell\QuickPictureViewer"; ValueType: string; ValueName: ""; ValueData: "Open with {#MyAppName}"; Flags: uninsdeletekey; Tasks: "openwith"
Root: HKCR; Subkey: "*\shell\QuickPictureViewer"; ValueType: string; ValueName: "Icon"; ValueData: """{app}\picture.ico"""; Flags: uninsdeletekey; Tasks: "openwith"
Root: HKCR; Subkey: "*\shell\QuickPictureViewer\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%V"""; Flags: uninsdeletekey; Tasks: "openwith"
; Browse folder with QuickPictureViewer
Root: HKCR; Subkey: "Directory\Background\shell\QuickPictureViewer"; ValueType: string; ValueName: ""; ValueData: "Browse folder with {#MyAppName}"; Flags: uninsdeletekey; Tasks: "browsefolder"
Root: HKCR; Subkey: "Directory\Background\shell\QuickPictureViewer"; ValueType: string; ValueName: "Icon"; ValueData: """{app}\picture.ico"""; Flags: uninsdeletekey; Tasks: "browsefolder"
Root: HKCR; Subkey: "Directory\Background\shell\QuickPictureViewer\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%V"""; Flags: uninsdeletekey; Tasks: "browsefolder"
Root: HKCR; Subkey: "Directory\shell\QuickPictureViewer"; ValueType: string; ValueName: ""; ValueData: "Browse folder with {#MyAppName}"; Flags: uninsdeletekey; Tasks: "browsefolder"
Root: HKCR; Subkey: "Directory\shell\QuickPictureViewer"; ValueType: string; ValueName: "Icon"; ValueData: """{app}\picture.ico"""; Flags: uninsdeletekey; Tasks: "browsefolder"
Root: HKCR; Subkey: "Directory\shell\QuickPictureViewer\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%V"""; Flags: uninsdeletekey; Tasks: "browsefolder"
; BMP
Root: HKCR; Subkey: ".bmp"; ValueType: string; ValueName: ""; ValueData: "BmpImg"; Flags: uninsdeletekey
Root: HKCR; Subkey: "BmpImg"; ValueType: string; ValueName: ""; ValueData: "BMP image (Bitmap image file)"; Flags: uninsdeletekey
Root: HKCR; Subkey: "BmpImg\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\icons\bmp.ico"
Root: HKCR; Subkey: "BmpImg\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
; DDS
Root: HKCR; Subkey: ".dds"; ValueType: string; ValueName: ""; ValueData: "DdsTexture"; Flags: uninsdeletevalue
Root: HKCR; Subkey: "DdsTexture"; ValueType: string; ValueName: ""; ValueData: "DDS texture (DirectDraw surface)"; Flags: uninsdeletekey
Root: HKCR; Subkey: "DdsTexture\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\icons\dds.ico"
Root: HKCR; Subkey: "DdsTexture\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
; DIB
Root: HKCR; Subkey: ".dib"; ValueType: string; ValueName: ""; ValueData: "DibImg"; Flags: uninsdeletevalue
Root: HKCR; Subkey: "DibImg"; ValueType: string; ValueName: ""; ValueData: "DIB image (Device independent bitmap)"; Flags: uninsdeletekey
Root: HKCR; Subkey: "DibImg\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\icons\dib.ico"
Root: HKCR; Subkey: "DibImg\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
; EXIF
Root: HKCR; Subkey: ".exif"; ValueType: string; ValueName: ""; ValueData: "ExifImg"; Flags: uninsdeletevalue
Root: HKCR; Subkey: "ExifImg"; ValueType: string; ValueName: ""; ValueData: "EXIF image (Exchangeable image file)"; Flags: uninsdeletekey
Root: HKCR; Subkey: "ExifImg\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\icons\exif.ico"
Root: HKCR; Subkey: "ExifImg\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
; GIF
Root: HKCR; Subkey: ".gif"; ValueType: string; ValueName: ""; ValueData: "GifImg"; Flags: uninsdeletevalue
Root: HKCR; Subkey: "GifImg"; ValueType: string; ValueName: ""; ValueData: "GIF image (Graphics interchange format)"; Flags: uninsdeletekey
Root: HKCR; Subkey: "GifImg\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\icons\gif.ico"
Root: HKCR; Subkey: "GifImg\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
; JFIF
Root: HKCR; Subkey: ".jfif"; ValueType: string; ValueName: ""; ValueData: "JfifImg"; Flags: uninsdeletevalue
Root: HKCR; Subkey: "JfifImg"; ValueType: string; ValueName: ""; ValueData: "JFIF image (JPEG file interchange format)"; Flags: uninsdeletekey
Root: HKCR; Subkey: "JfifImg\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\icons\jfif.ico"
Root: HKCR; Subkey: "JfifImg\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
; JPE
Root: HKCR; Subkey: ".jpe"; ValueType: string; ValueName: ""; ValueData: "JpeImg"; Flags: uninsdeletevalue
Root: HKCR; Subkey: "JpeImg"; ValueType: string; ValueName: ""; ValueData: "JPE image (Joint photographic experts group)"; Flags: uninsdeletekey
Root: HKCR; Subkey: "JpeImg\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\icons\jpg.ico"
Root: HKCR; Subkey: "JpeImg\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
; JPG
Root: HKCR; Subkey: ".jpeg"; ValueType: string; ValueName: ""; ValueData: "JpegImg"; Flags: uninsdeletevalue
Root: HKCR; Subkey: "JpegImg"; ValueType: string; ValueName: ""; ValueData: "JPEG image (Joint photographic experts group)"; Flags: uninsdeletekey
Root: HKCR; Subkey: "JpegImg\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\icons\jpg.ico"
Root: HKCR; Subkey: "JpegImg\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
; JPG
Root: HKCR; Subkey: ".jpg"; ValueType: string; ValueName: ""; ValueData: "JpgImg"; Flags: uninsdeletevalue
Root: HKCR; Subkey: "JpgImg"; ValueType: string; ValueName: ""; ValueData: "JPG image (Joint photographic experts group)"; Flags: uninsdeletekey
Root: HKCR; Subkey: "JpgImg\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\icons\jpg.ico"
Root: HKCR; Subkey: "JpgImg\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
; PNG
Root: HKCR; Subkey: ".png"; ValueType: string; ValueName: ""; ValueData: "PngImg"; Flags: uninsdeletevalue
Root: HKCR; Subkey: "PngImg"; ValueType: string; ValueName: ""; ValueData: "PNG image (Portable network graphics)"; Flags: uninsdeletekey
Root: HKCR; Subkey: "PngImg\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\icons\png.ico"
Root: HKCR; Subkey: "PngImg\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
; RLE
Root: HKCR; Subkey: ".rle"; ValueType: string; ValueName: ""; ValueData: "RleImg"; Flags: uninsdeletevalue
Root: HKCR; Subkey: "RleImg"; ValueType: string; ValueName: ""; ValueData: "RLE image (Run length encoded bitmap)"; Flags: uninsdeletekey
Root: HKCR; Subkey: "RleImg\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\icons\rle.ico"
Root: HKCR; Subkey: "RleImg\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
; SVG
Root: HKCR; Subkey: ".svg"; ValueType: string; ValueName: ""; ValueData: "SvgImg"; Flags: uninsdeletevalue
Root: HKCR; Subkey: "SvgImg"; ValueType: string; ValueName: ""; ValueData: "SVG image (Scalable vector graphics)"; Flags: uninsdeletekey
Root: HKCR; Subkey: "SvgImg\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\icons\svg.ico"
Root: HKCR; Subkey: "SvgImg\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
; TGA
Root: HKCR; Subkey: ".tga"; ValueType: string; ValueName: ""; ValueData: "TgaTexture"; Flags: uninsdeletevalue
Root: HKCR; Subkey: "TgaTexture"; ValueType: string; ValueName: ""; ValueData: "TGA texture (Truevision advanced raster graphics)"; Flags: uninsdeletekey
Root: HKCR; Subkey: "TgaTexture\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\icons\tga.ico"
Root: HKCR; Subkey: "TgaTexture\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
; TIF
Root: HKCR; Subkey: ".tif"; ValueType: string; ValueName: ""; ValueData: "TifImg"; Flags: uninsdeletevalue
Root: HKCR; Subkey: "TifImg"; ValueType: string; ValueName: ""; ValueData: "TIF image (Tagged image file format)"; Flags: uninsdeletekey
Root: HKCR; Subkey: "TifImg\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\icons\tif.ico"
Root: HKCR; Subkey: "TifImg\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
; TIFF
Root: HKCR; Subkey: ".tiff"; ValueType: string; ValueName: ""; ValueData: "TiffImg"; Flags: uninsdeletevalue
Root: HKCR; Subkey: "TiffImg"; ValueType: string; ValueName: ""; ValueData: "TIFF image (Tagged image file format)"; Flags: uninsdeletekey
Root: HKCR; Subkey: "TiffImg\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\icons\tif.ico"
Root: HKCR; Subkey: "TiffImg\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
; WEBP
Root: HKCR; Subkey: ".webp"; ValueType: string; ValueName: ""; ValueData: "WebpImg"; Flags: uninsdeletevalue
Root: HKCR; Subkey: "WebpImg"; ValueType: string; ValueName: ""; ValueData: "WEBP image (Google web picture)"; Flags: uninsdeletekey
Root: HKCR; Subkey: "WebpImg\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\icons\webp.ico"
Root: HKCR; Subkey: "WebpImg\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
; PSD
Root: HKCR; Subkey: ".psd"; ValueType: string; ValueName: ""; ValueData: "PsdImg"; Flags: uninsdeletevalue
Root: HKCR; Subkey: "PsdImg"; ValueType: string; ValueName: ""; ValueData: "PSD file (Photoshop Document)"; Flags: uninsdeletekey
Root: HKCR; Subkey: "PsdImg\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\icons\psd.ico"
Root: HKCR; Subkey: "PsdImg\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
; CR2
Root: HKCR; Subkey: ".cr2"; ValueType: string; ValueName: ""; ValueData: "Cr2Img"; Flags: uninsdeletevalue
Root: HKCR; Subkey: "Cr2Img"; ValueType: string; ValueName: ""; ValueData: "CR2 image (Canon Digital Camera Raw)"; Flags: uninsdeletekey
Root: HKCR; Subkey: "Cr2Img\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\icons\cr2.ico"
Root: HKCR; Subkey: "Cr2Img\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""