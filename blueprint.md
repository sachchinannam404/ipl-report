# IPL Report Application

## Overview

This application displays information about the Indian Premier League (IPL), including players, teams, and coaches. The application is built using ASP.NET Core with Razor Pages and uses an in-memory database.

## Features

*   **Players:** View a list of players and their teams.
*   **Teams:** View a list of teams and their coaches.
*   **Coaches:** View a list of coaches and their teams.

## Project Structure

*   **`Pages/`**: Contains the Razor Pages for the application.
*   **`Data/`**: Contains the `ApplicationDbContext` for database interactions.
*   **`Models/`**: Contains the data models for Player, Team, and Coach.
*   **`wwwroot/`**: Contains static assets like CSS and JavaScript.
*   **`Program.cs`**: The main entry point of the application, where services are configured and the application is run.
*   **`myapp.csproj`**: The project file for the application.
*   **`blueprint.md`**: This file, providing an overview of the project.

## Current Task: Initial Setup

*   [x] Set up the ASP.NET Core project.
*   [x] Create the data models for Player, Team, and Coach.
*   [x] Create the `ApplicationDbContext` and configure it to use an in-memory database.
*   [x] Seed the database with initial data.
*   [x] Create Razor Pages to display the lists of Players, Teams, and Coaches.
*   [x] Create a layout with navigation to the different pages.
*   [x] Create a home page.
*   [x] Create this `blueprint.md` file.