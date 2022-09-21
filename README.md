# BugManagement
Bug management application

There are two types of accounts: tester and programmer.<br/>
Testers can add bugs to the list. A bug has a description, a list of steps to reproduce the bug,
a status (just added/solved/checked) and a review.<br/>

## Functionalities

Logged in to any type of account:
- View list of bugs, with their description, status and review
- View list of steps for a bug
- View and send messages
<br/>

Logged as tester:
- Add bug
- Add bug step (+ update/delete)
- Change bug status to any status
<br/>

Logged as programmer:
- Mark bug as solved
- Mark a solved bug as checked
- Change bug review
<br/>

## Screenshots

### Login
![login](https://user-images.githubusercontent.com/92738316/191441742-f95665f9-ced5-448a-9d79-2d97f59a417a.jpg)

### Main page
![main](https://user-images.githubusercontent.com/92738316/191441792-a203e928-cbb1-4e79-8f25-807f33e30b96.jpg)

### Messages
![messages](https://user-images.githubusercontent.com/92738316/191441836-e2ce86c1-9b95-4925-9fbf-b17f9b1442e0.jpg)

### Bugs page for a tester
![bugs_as_tester](https://user-images.githubusercontent.com/92738316/191441920-6d26fa6f-01e0-4970-b5bf-cb932e12b411.jpg)

### Bugs page for a programmer
![bugs_as_programmer](https://user-images.githubusercontent.com/92738316/191441966-bc3c4307-4720-428d-84d5-ef1763d8f759.jpg)

## Technology stack
- C#
- Entity Framework
- SQL Server
