# FakeRebootAlert

This is a basic Windows Forms App designed to display a popup asking users to reboot their machine. It can be useful in scenarios where a system restart is necessary for changes to take effect, such as when modifications have been made to registry keys (e.g., Protected Process Light (PPL) settings).

To make it look legitimate, the popup message includes the system's hostname and the icon of a program installed in the machine. The icon is included as a base64 blob and can be updated for the icon of any other program using the variable "*base64Icon*" in *Program.cs* file.

![img1](https://raw.githubusercontent.com/ricardojoserf/ricardojoserf.github.io/refs/heads/master/images/fakerebootalert/Screenshot_1.png)


-----------------------------------------------

## Motivation

It is increasingly common to find PPL protection enabled by default in Windows systems. Even with administrator privileges, modifying the corresponding registry key requires a system restart for the changes to take effect. 

However, restarting the computer can be risky in certain scenarios. In such cases, waiting for users to reboot naturally may seem like a safer option, but it is not always feasible to wait for weeks or months. To address this, we can use this tool to prompt users to reboot prematurely, encouraging them to restart the system on their own.

-----------------------------------------------

## Usage example: Startup Folder

The tool can be configured to launch automatically when a user logs in using Auto Start Extensibility Points (ASEPs) such as the Startup Folder. 

To do this, place a shortcut or the executable itself in the Startup Folder for a specific user:

```
%APPDATA%\Microsoft\Windows\Start Menu\Programs\Startup
```

Or use the System-wide Startup folder, which would make the message prompt for any user who logs in:

```
C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup
```

Another ASEP example is registry keys such as "*HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run*" (for a specific user) or "*HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Run*" (for all users).
