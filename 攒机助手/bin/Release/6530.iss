; 脚本由 Inno Setup 脚本向导 生成！
; 有关创建 Inno Setup 脚本文件的详细资料请查阅帮助文档！

#define MyAppName "攒机助手专业版"
#define MyAppVersion "6.5.3.0"
#define MyAppPublisher "萝卜头IT论坛"
#define MyAppURL "http://bbs.luobotou.org/forum-116-1.html"
#define MyAppExeName "攒机助手专业版.exe"

[Setup]
; 注: AppId的值为单独标识该应用程序。
; 不要为其他安装程序使用相同的AppId值。
; (生成新的GUID，点击 工具|在IDE中生成GUID。)
AppId={{9E3E37FB-AF59-48BC-8E6E-D47F6B224468}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\CjzsPro
DefaultGroupName={#MyAppName}
LicenseFile=D:\MyProgram\攒机助手Pro\攒机助手\bin\Release\许可协议.txt
OutputBaseFilename=setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "chinesesimp"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "D:\MyProgram\攒机助手Pro\攒机助手\bin\Release\攒机助手专业版.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\MyProgram\攒机助手Pro\攒机助手\bin\Release\cjzs_.doc"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\MyProgram\攒机助手Pro\攒机助手\bin\Release\data.mdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\MyProgram\攒机助手Pro\攒机助手\bin\Release\data.mdb.zip"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\MyProgram\攒机助手Pro\攒机助手\bin\Release\hw.mdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\MyProgram\攒机助手Pro\攒机助手\bin\Release\Microsoft.Office.Interop.Excel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\MyProgram\攒机助手Pro\攒机助手\bin\Release\Microsoft.Office.Interop.Word.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\MyProgram\攒机助手Pro\攒机助手\bin\Release\Office.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\MyProgram\攒机助手Pro\攒机助手\bin\Release\sell.mdb"; DestDir: "{app}"; Flags: ignoreversion
; 注意: 不要在任何共享系统文件上使用“Flags: ignoreversion”

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

