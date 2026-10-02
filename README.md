# GearGo MVC

GearGo is an ASP.NET Core MVC web application for a small equipment-rental business. Customers can browse available equipment and request rentals, while staff and managers can manage equipment, rental requests and users.

## Project Overview

GearGo supports the rental of different types of equipment, including:

- Camping equipment
- Power tools
- Event equipment

The application is being developed incrementally across multiple practical lab sessions. The project demonstrates business analysis, MVC architecture, GitHub collaboration and the development of a first vertical slice.

## Project Goals

The main goals of GearGo are to:

- Allow customers to browse available equipment.
- Allow customers to request equipment rentals.
- Allow staff to manage equipment and rental requests.
- Allow managers to manage the equipment catalogue and users.
- Demonstrate the use of the Model-View-Controller pattern.
- Practise collaborative development using Git and GitHub.

## Technology Stack

- C#
- ASP.NET Core MVC
- .NET SDK
- Entity Framework Core
- HTML
- CSS
- Git
- GitHub
- Visual Studio, Visual Studio Code or JetBrains Rider

## MVC Architecture

The application follows the MVC design pattern:

- **Models** represent the application's data and business entities.
- **Views** provide the user interface displayed in the browser.
- **Controllers** handle user requests and coordinate the models and views.

The first planned vertical slice will allow users to view equipment available for rental.

## Planned Features

### Customer Features

- View available equipment.
- View equipment details.
- Submit a rental request.
- View rental request status.

### Staff Features

- Add equipment.
- Edit equipment details.
- Remove or deactivate equipment.
- View and manage rental requests.

### Manager Features

- Manage the equipment catalogue.
- Manage users and roles.
- View administrative information.

## Repository Workflow

The team will use the following GitHub workflow:

1. Create an Issue for each task.
2. Assign the Issue to one team member.
3. Create a feature branch from `main`.
4. Complete the work on the feature branch.
5. Commit changes using clear commit messages.
6. Push the branch to GitHub.
7. Open a Pull Request.
8. Ask another team member to review the changes.
9. Resolve review comments.
10. Merge the Pull Request into `main`.

## Business Problem Analysis

### Problem Statement

GearGo currently needs a simple and organised way to manage its equipment-rental process. Customers need to know which equipment is available and submit rental requests. Staff need to manage equipment and process rental requests, while managers need administrative control over the equipment catalogue and users.

The current problem is that rental information may be difficult to track if it is managed manually or across separate systems. This can lead to inaccurate equipment availability, delayed responses, duplicate bookings and limited visibility of rental requests.

The affected users are:

- **Customers**, who need to browse equipment and request rentals.
- **Staff**, who need to manage equipment and respond to rental requests.
- **Managers**, who need administrative control and oversight of the system.

The business impact may include:

- Increased time spent managing rental information.
- Incorrect or outdated equipment availability.
- Delays when processing rental requests.
- Difficulty tracking the status of requests.
- Reduced visibility for managers.
- Poor customer experience.

### Proposed Solution Boundary

The GearGo MVC application will provide a small web-based system that allows:

- Customers to browse available equipment.
- Customers to submit rental requests.
- Staff to view and manage equipment.
- Staff to review and update rental requests.
- Managers to manage the equipment catalogue and users.

The first version will focus on the core rental process. It will not initially include online payments, delivery tracking, advanced reporting, external supplier integrations or a full commercial booking system.

### Team Members

| Name | Role |
| --- | --- |
| Claud-James Blignaut | Administrator |
| Marco Jacobus Janse van Rensburg | Administrator |
| Pieter Johannes Jacob van Straten | Business Analyst |
| Izak Van Heerden | Developer |
| Tiaan Dewald Arpin | Business Analyst |


