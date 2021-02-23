$ErrorActionPreference = 'Stop';

$packageName= 'quick-picture-viewer'
$toolsDir   = "$(Split-Path -parent $MyInvocation.MyCommand.Definition)"
$url        = 'https://github.com/ModuleArt/quick-picture-viewer/releases/download/v3.0.4/QuickPictureViewer-Setup.exe' 
$url64      = 'https://github.com/ModuleArt/quick-picture-viewer/releases/download/v3.0.4/QuickPictureViewer-Setup.exe'

$packageArgs = @{
  packageName   = $packageName
  unzipLocation = $toolsDir
  fileType      = 'EXE'
  url           = $url
  url64bit      = $url64

  validExitCodes= @(0)
  silentArgs   = '/VERYSILENT /SUPPRESSMSGBOXES /NORESTART /SP-'

  softwareName  = 'quick-picture-viewer'
  checksum      = ''
  checksumType  = 'md5'
  checksum64    = ''
  checksumType64= 'md5'
}

Install-ChocolateyPackage @packageArgs