# Shodan-Desktop
Call Shodan's RESTful API

This is one of my very first projects with C#/WinForms.
It is a very simple C# WinForms Application that I made to get familiar with RESTful APIs.
I used JSON.net to call the Shodan RESTful API.


This project has a lot of things wrong with it that I have learned from. 
1. C#/ASP.NET use Pascal casing over camel case. I was coming from mainly a Java background and was still using camel casing.
2. One class per file rule was thrown out the window and made my program a lot more complicated and difficult to read than it should have been. In the future I hope to have time to rewrite this with separate class files. 
3. DRY (Do not repeat yourself) was also not followed. I was mainly focused on familiarizing myself with C#, Visual Studio, and Git Version Control.

APIs are really cool and a great way to make you feel like you are doing a lot more than you really are. It was encouraging to have immediate feedback and know I was actually communicating with Shodan's servers.


Upcoming Features: 
1. Improve the presentation of the JSON formatted information into a TreeView structure.
2. Export filtered selected information into a CSV to make it easier to work with.
3. Improve UI/UX to make the application more appealing and easier to use.

You can also visit my website to download the installer. 
(Side Interesting Idea: I would like to figure out how to containerize this and allow users to view it through noVNC through the awesome power of Web Sockets)

https://www.letshax.com/shodan-desktop-rest-api/

![shodan desktop](https://i.imgur.com/FMHqPEn.png)


