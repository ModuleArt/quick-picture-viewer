$ErrorActionPreference = 'Stop';

$packageName= 'quick-picture-viewer'
$toolsDir   = "$(Split-Path -parent $MyInvocation.MyCommand.Definition)"
$url        = 'https://github.com/ModuleArt/quick-picture-viewer/releases/download/v3.0.4/QuickPictureViewer-Setup.exe' 

$packageArgs = @{
  packageName   = $packageName
  fileType      = 'EXE'
  url           = $url
  validExitCodes= @(0)
  silentArgs   = '/VERYSILENT /SUPPRESSMSGBOXES /NORESTART /SP-'
  softwareName  = 'quick-picture-viewer'
  checksum      = 'BA12911B42654B26CDD81714A2220BA3'
  checksumType  = 'md5'
}

Install-ChocolateyPackage @packageArgs