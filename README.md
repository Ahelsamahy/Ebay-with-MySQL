<h2 align="center">bay isn't a typo, it is an uncle joke</h2>
<p style="font-size:15px" align="center">
  <a href="#Introduction">Introduction</a> •
  <a href="#How-it-works">How it Works</a> •
  <a href="#Installation">Installation</a> •
  <a href="#Functionalities">Scope of functionalities</a> •
  <a href="#emailware">Emailware</a> •
  <a href="#license">License</a>
</p>

<p align="center">
<img src="https://github.com/Ahelsamahy/Ebay-with-MySQL/blob/main/assets/Home.png?raw=true" >
</p>


# Introduction
Coming back to you again from the same teacher that gave me 4 on the [RESTful-API-in-NodeJs](https://github.com/Ahelsamahy/RESTful-API-in-NodeJs) project, but this time different because I got 5 🥳.

The idea was to make a client  side (WCFEbayClient) that is connected to server (WCFEbayServer) that handles actions from host (WCFEbayClient) in the database made with MySQL in DBeaver.

# How-it-works

Heads up, lot of talking is coming ahead. So first there is an instance from host is running that is responsible about giving the data to the client side, the user interacts with the form on the client side, then it sends the request to host then to server where a SQL statement runs on the database and returns the value to the client side in the right data field to show it.


# Installation

1. Clone this repository ```git clone https://github.com/Ahelsamahy/Ebay-with-MySQL```


> ⚠️ Make sure to run Visual Studio as admin for the WCFEbayServer

2. Run new instance from debug, you will be prompt to firewall message to allow the application, accept it then you should see a console window with the starting time of the app.

3. Open another instance of visual studio to run the Client side (WCFEbayClient), just press F5 and you will be good to go 👍

<p align="center">
<img src="https://github.com/Ahelsamahy/Ebay-with-MySQL/blob/main/assets/AdminStart.gif?raw=true" title="Visually Go, Go" >
</p>

# Functionalities
- View all Cars with their data directly from database
    - using `GetCars()` in WCFEbayServer

- Add Cars with incremented ID number
    - using `SaveCars()` in WCFEbayServer and `SaveCars` procedure in database

- Delete car using their ID
    - using `DeleteCars()` in WCFEbayServer and `DeleteCars` procedure in database

<p style="font-size:10px">*same applies with user </p>

# Used Technologies
MySQL: dealing with database.

C#: bro look at the language on the right side, it's C# 100%.

.Net framework: for making all of it .

WCF: creating the interactive form in the WCFEbayClient.



# Emailware
Ebay-with-MySQL is an [emailware](https://en.wiktionary.org/wiki/emailware). Meaning, if you liked using this app or it has helped you in any way, I'd like you send me an email at <ahmelsamahy@gmail.com> about anything you'd want to say about this software. I'd really appreciate it!

# License
If you have project similar to this which you will use this instead in it or you may use this project, don't forget to mention me or send me email about it.