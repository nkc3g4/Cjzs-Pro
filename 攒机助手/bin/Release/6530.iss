; �ű��� Inno Setup �ű��� ���ɣ�
; �йش��� Inno Setup �ű��ļ�����ϸ��������İ����ĵ���

#define MyAppName "�ܻ�����רҵ��"
#define MyAppVersion "6.5.3.0"
#define MyAppPublisher "�ܲ�ͷIT��̳"
#define MyAppURL "http://bbs.luobotou.org/forum-116-1.html"
#define MyAppExeName "�ܻ�����רҵ��.exe"

[Setup]
; ע: AppId��ֵΪ������ʶ��Ӧ�ó���
; ��ҪΪ������װ����ʹ����ͬ��AppIdֵ��
; (�����µ�GUID����� ����|��IDE������GUID��)
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
LicenseFile=D:\MyProgram\�ܻ�����Pro\�ܻ�����\bin\Release\���Э��.txt
OutputBaseFilename=setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "chinesesimp"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "D:\MyProgram\�ܻ�����Pro\�ܻ�����\bin\Release\�ܻ�����רҵ��.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\MyProgram\�ܻ�����Pro\�ܻ�����\bin\Release\cjzs_.doc"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\MyProgram\�ܻ�����Pro\�ܻ�����\bin\Release\data.mdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\MyProgram\�ܻ�����Pro\�ܻ�����\bin\Release\data.mdb.zip"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\MyProgram\�ܻ�����Pro\�ܻ�����\bin\Release\hw.mdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\MyProgram\�ܻ�����Pro\�ܻ�����\bin\Release\Microsoft.Office.Interop.Excel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\MyProgram\�ܻ�����Pro\�ܻ�����\bin\Release\Microsoft.Office.Interop.Word.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\MyProgram\�ܻ�����Pro\�ܻ�����\bin\Release\Office.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\MyProgram\�ܻ�����Pro\�ܻ�����\bin\Release\sell.mdb"; DestDir: "{app}"; Flags: ignoreversion
; ע��: ��Ҫ���κι���ϵͳ�ļ���ʹ�á�Flags: ignoreversion��

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

