# International Space Station ISS Tracker


## Description

This repository contains a desktop application called International Space Station ISS Tracker, developed using C#, .NET, API, and JSON. The application allows users to track satellites in both live and static modes. It retrieves satellite data from the N2YO API (https://www.n2yo.com/api/) and presents it in a tabular format.

## Features

The Live Satellite Tracker currently offers the following features:

- Tracking of the International Space Station (ISS): The application retrieves real-time data for the ISS, including its name, ID, altitude, latitude, longitude, and timestamp.

- Tabular Display: The retrieved satellite data is presented in a table format for easy viewing and analysis.

- Expandable Satellite Database: The application has the capability to track additional satellites by utilising a personal API key, generated through the N2YO website. This allows for flexibility in expanding the satellite tracking functionality.

The tracking details such as Longitude & Altitude can be viewed in either live or static mode.

- Static Mode: allows users to see results at a specific point with the TimeStamp also displayed with the results.
This can be used for report analysis or for basic research purposes.

- Live Mode: allows users to see results at any given time with the results updating per second.
This can be beneficial in order to track the location to see where it may be.

## App Usage

To use the International Space Station ISS Tracker application, follow these steps:

1. Clone the repository to your local machine using the following command:

    git clone https://github.com/sufiyan3r/international-space-station-iss-tracker.git

2. Open the project in your preferred Integrated Development Environment (IDE) that supports C# and .NET.

3. Ensure that the necessary dependencies are installed. You may need to restore NuGet packages if they are not automatically installed.

4. Obtain a personal API key from the N2YO website (https://www.n2yo.com/api/). This key will be required to access satellite data.

5. Replace the placeholder API key in the application code with your personal API key. Locate the relevant section in the codebase and update it accordingly.

6. Build the application.

7. Run the application, and you will be able to track the International Space Station (ISS) using the provided table view.

## Future Improvements

The Live Satellite Tracker project has the potential for further enhancements. Some possible future improvements include:

- Velocity Tracking: Addition of satellite velocity information to provide a more comprehensive view of the satellite's movement.

- Live Map Visualisation: Integration of a live map visualization feature to display the satellite's current position on a map.

- Additional Pages: Creation of additional pages within the application to provide users with more detailed information about satellites, their trajectories, and other related data.
