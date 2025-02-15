


# MEAGLE 1.3 README


by Eesha Sukhavasi

Dunlap High School
Dunlap, IL

Meagle is a Mobile Application that is compatible with both Android and iOS phones. This app acts as a bridge to create seamless communication amongst parents, students, and administration at Dunlap High School. Meagle runs error/bug free, however in the case of any issues there is a way for users to easily report bugs or potential issues that they may be experiencing while using the application. 


![]()

## Features

- Compatible with both Android and iOS
- Gmail login/account creation for quick account access/creation
- Contains a school calendar to keep track of holidays,half-days, and start-dates/end-dates
- Athletics calendar seperated by activity and season
- Important contacts section with phone numbers, email id's, and website address
- A way for parents to report absences
- Displaying lunch menus
- Connections to Dunlap High's various social media platforms(Twitter, Instagram, Facebook)
- Bus changes tracker to keep tracking of any bus number changes or arrival status
- A way for app users to share photos amongst other app users
- Safety reporting(sending reports on concerning/suspicious activity that could pose harm)
- Student self reporting(a way for students to discuss their personal needs/concerns(bullying, etc.))
- Report any bugs to us with screenshots, or recordings of the issue

## Folder Layout

**/CompiledApp**
> Contains our compiled, signed app in APK form for Android platforms

**/Documentation**
> Contains PDF overview of the app along with screenshots and explanations of all functionality

**/Source**
> Contains Visual Studio 2023 solution file (NOTE: Requires Cross-Platform Visual Studio 2023 Add on)


## How to Run

This mobile application was developed in C++ using Visual Studio 2023 and the Xamarin 
Platform on Microsoft Windows.   Contained within the submission 
is a folder named “CompiledApp” that contains a signed APK that was created for Android 
phones and emulators. Simply install the APK to your Android mobile device and run.

Please note that because the Windows Phone platform has been discontinued by Microsoft, 
it would be inaccurate to judge our entry based off of strictly running the UWP version 
of the app. Certain features such as bug reporting are only available on Android and iOS 
systems.

[Download Release 1.3]

##User Guide
School Calendar- Just scroll through to find the different dates with the most important information
Absence Reporter- Fill in the student's ID, Student Name(First and last), and students email first. Then fill in parent imformation such as phone number, parent email, the reason for absence, the dates that you will be gone. Once you submit, a confirmation email will be sent to you, just in case you wish to cancel your absence reporting. The office team will reacive this information, and mark your student out.
Submit a safety report- This is to send in any sort of suspicious activity that you might see around the building that needs to be brought to the attention of the administration. The office team will take these concerns into consideration as soon as you send a report, and evaluate them. 
Report a bug- Submit a report for any issues that you may encounter while using the app. As soon as it is submitted someone will take a look, and find a way to help you out asap!
Important Contacts- Scroll through to find any important information you may need, and click on the website icon to easily access the wbsite. 
Social Media- Contains Twitter, Facebook, and Instagram page connections for the school. 
Create support Request- Talk about your personal concerns, and  these will stay confidential. Enter your name, email, and phone number, and desired way to contact. The counseling services will have access to this information to further discuss your concerns. 
Bus Information request- Request bus infromation, and yoru request in transferred to the transportation departments at Dunlap High. 
Submit a photo- Send in an image image, and the school's social media team will look at your query, and upload it to the correct school social media platform. 
Cafeteria Menus- Scroll through to find what the cafeteria has to offer. 
Activities Schedule- Has all the announcements and timings for when certain sports games start, and where they are at. 



## Build Instructions

Visual Studio Requirements:
- Visual Studio 2017 (Windows or Mac) Community Edition
- Cross-Platform Add-on
- (If Mac) XCode
- Android Platform 28 SDK (Pie)

In order to build for IOS you will need OSX with both XCode and Visual Studio for Mac fully  updated and an Internet connection. Upon opening the Visual Studio solution it will immediately download all necessary packages from Nuget. You will need to execute a debug version of Meagle using the iPhone Simulator.   We recommend utilizing the iPhone XS Max iOS 12.1 simulator.

In order to build for Android you will need Visual Studio or Visual Studio for Mac. Upon opening the Visual Studio solution it will immediately download all necessary packages from Nuget. You will need to execute a debug version of the Meagle project either on a simulator or by connecting an Android mobile device that has Developer Options and Enable USB debugging turned on.   

Enjoy!

## Other Notes ##

- All of the code in Meagle is error free and can be run with no issues.  
- Meagle is entirely written in C++ using the Xamarin Framework.
- The navigation between pages is also error free and take the user to the intended pages.
- The Meagle app is compatible with Android/iOS phones and tablets.
- The data that is collected from the app is secure.


## Resources Used ##

### Media Assets

#### Google Material Design Icons ####
                                        
Copyright 2019 Google

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
<br/><br/>                                        
#### Sound Effects Obtained via Creative Commons Attribution License ####
                                        
negative_beeps.wav by themusicalnomad
> [https://freesound.org/people/themusicalnomad/sounds/253886/](https://freesound.org/people/themusicalnomad/sounds/253886/)

ultradust_clock.wav by ultradust 
> [https://freesound.org/people/ultradust/sounds/167385/](https://freesound.org/people/ultradust/sounds/167385/)

error.wav by distillerystudio 
> [https://freesound.org/people/distillerystudio/sounds/327737/](https://freesound.org/people/distillerystudio/sounds/327737/)

incorrect.wav by bertrof 
> [https://freesound.org/people/Bertrof/sounds/351565/](https://freesound.org/people/Bertrof/sounds/351565/)

correct.wav by bertrof 
> [https://freesound.org/people/Bertrof/sounds/351566/](https://freesound.org/people/Bertrof/sounds/351566/)

<br/><br/>                       
#### Additional sound effects from [https://www.zapsplat.com](https://www.zapsplat.com) ####

### Lottie Animations obtained from LottieFiles.com ###
Lottie animatons were not altered in any way and obtained via Creative Commons Attribution License
[https://creativecommons.org/licenses/by/4.0/](https://creativecommons.org/licenses/by/4.0/)
                                        
"Checked Done" by LottieFiles - [https://lottiefiles.com/433-checked-done](https://lottiefiles.com/433-checked-done)

"Wrong Answer" by Pedro Silva -[https://lottiefiles.com/4698-wrong-answer](https://lottiefiles.com/4698-wrong-answer)

"Material Loader" by LottieFiles - [https://lottiefiles.com/50-material-loader](https://lottiefiles.com/50-material-loader)
                                        
"AashishDeleteAnimation" by Aashish Soam - [https://lottiefiles.com/5474-aashishdeleteanimation](https://lottiefiles.com/5474-aashishdeleteanimation)

"Trophy" by Lucas Nemo - [https://lottiefiles.com/677-trophy](https://lottiefiles.com/677-trophy)   
<br/><br/>

## Software and Services Used ##
Meagle  was developed using the following software applications and services: 

Auth0 - [https://www.auth0.com](https://www.auth0.com)
> Purpose: Auth0 provides a universal authentication & authorization platform for web, mobile and legacy applications.  You can easily and quickly connect your apps, choose identity providers, add users, set up rules, customize your login page and access analytics from one dashboard
 
GameSparks - [https://www.gamesparks.com/](https://www.gamesparks.com/)
> Purpose: GameSparks is a cloud-based solution for game developers that helps them to build their server-side components without ever having to set up and run a server.  We used GameSparks for storage of user accounts and score tracking.

Github - [https://github.com/](https://github.com/) 
> Purpose: Github is an online source hosting service based around the Git version control system.  We utilized Github to store source code revisions during this project. 
 
Gitkraken - [https://www.gitkraken.com/](https://www.gitkraken.com/)
>Purpose:  Gitkraken was utilized to manage code revisions, resolve merge conflicts, and test experimental branch features. 
 
 
Microsoft App Center - [http://appcenter.ms](http://appcenter.ms) 
>Purpose:  Captures analytics information to allow us to learn Meagle usage patterns as well as logs information about application crashes and any generated exception errors. 
 
Microsoft Visual Studio 2023
>Purpose:  IDE for developing Xamarin.Forms applications in C++

Photopea [https://www.photopea.com/](https://www.photopea.com/) 
>Purpose:  Photopea is an online graphics editor that is similar to Adobe Photoshop. We used Photopea to manipulate all of our graphics. 
<br/><br/>

## Additional Software Components ##
The following software components are also part of the QuizzicalFBLA app: 


Com.Airbnb.Xamarin.Forms.Lottie by Martijn van Dijk - [https://www.nuget.org/packages/Com.Airbnb.Xamarin.Forms.Lottie/](https://www.nuget.org/packages/Com.Airbnb.Xamarin.Forms.Lottie/)
> Render After Effects animations natively on Android, iOS, MacOS, TVOs and UWP

Newtonsoft.Json by James Newton-King - [https://www.nuget.org/packages/Newtonsoft.Json/](https://www.nuget.org/packages/Newtonsoft.Json/)
> Json.NET is a popular high-performance JSON framework for .NET

Xam.Plugin.SimpleAudioPlayer by Adrian Stevens - [https://www.nuget.org/packages/Xam.Plugin.SimpleAudioPlayer/](https://www.nuget.org/packages/Xam.Plugin.SimpleAudioPlayer/)
> A light-weight and easy to use cross-platform audio player for Windows UWP/WPF, Xamarin.iOS, Xamarin.Android, Xamarin.Mac, Xamarin.tvOS, Tizen and Xamarin.Forms. Load wav and mp3 files from any location including a shared library. Works well for sound effects or music. Multiple instances can be instantiated to play multiple sources simultaniously.

Xamarin.Essentials by Microsoft - [https://www.nuget.org/packages/Xamarin.Essentials/](https://www.nuget.org/packages/Xamarin.Essentials/)
> Xamarin.Essentials: a kit of essential API's for your apps

Xamarin.Forms.PancakeView by Steven Thewissen - [https://www.nuget.org/packages/Xamarin.Forms.PancakeView/](https://www.nuget.org/packages/Xamarin.Forms.PancakeView/)
>An extended ContentView for Xamarin.Forms with rounded corners, borders, shadows and more!
<br/><br/>


## License ##

The MIT License (MIT)

Copyright (c) 2023 Eesha Sukhavasi

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

