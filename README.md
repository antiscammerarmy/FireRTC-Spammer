# FireRTC-Spammer
A simple application that will repeatedly spam a phone number with spoofed phone numbers using FireRTC.

# Non-Developer Download
Download the program here if you want the latest stable version (release version 0.1): https://www.dropbox.com/s/pc9inxx476amdmg/FireRTC%20Spammer%20Release.zip?dl=0

# How to Use
The program will start by asking you, the end user, for your FireRTC (www.firertc.com) credentials. It will then ask for the phone number  you would like to spam and what the interval between each call should be. Using WebDriver, it will then open an instance of Google Chrome, ask the user to hit "Accept" on a dialog box once and start spamming!

# Navigating the Repository
The only two files that contain my code are FireRTCSpammer\MainForm.cs and FireRTCSpammer\Program.cs. Program.cs is where all the magic with the automation happens and MainForm.cs is simply the form used to authenticate into FireRTC, set the phone number we want to spam, etc.

# Terms and Condtions
Please do not use this software to repeatedly call places of business or an unknowing victim. I do not condone these behaviors and I am not responsible for what you do with my program. I am also not responsible if your FireRTC account is terminated as a result of this program.

# System Requirements
- .NET Framework version 4.5.2 or above.
- The latest version of Google Chrome.
- A decent Internet connection.

# Why GitHub?
I'm still a fairly new developer. There are things I would like to see improved in this program; does it break a lot in its current state? Yes. Would I rather it not break a lot? Of course. The goal here is to allow other developers to critique my work and help make it more stable while I learn a thing or two. Hopefully, if you're a new developer, you will find this repository useful in some way or another.
