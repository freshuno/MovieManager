# 🎬 Movie Manager

Movie Manager is a desktop application for managing your personal movie collection. It uses a MySQL database and the external OMDb API to fetch movie and series information.

---

## ⚙️ System Requirements

- Windows 10/11 (x64)
- Internet connection (for fetching data from the OMDb API)

---

## ✅ Step-by-Step Installation

### 1. Install .NET Runtime (if you don't have it)

To run the application, install the .NET Desktop Runtime 9.0.4:

👉 [Download the installer](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-desktop-9.0.4-windows-x64-installer?cid=getdotnetcore)

---

### 2. Install MySQL Server (if you don't have it)

1. Download the MySQL Server installer:  
   👉 [MySQL Download](https://dev.mysql.com/downloads/mysql/)

   > ⚠️ Note: If you encounter an error during the MySQL installation, try installing [this](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170) first.

2. You can leave the default settings during installation.  
3. **Remember the password** you set for the `root` user — it will be required when launching the application.

---

### 3. Generate a Free OMDb API Key

1. Go to the following page:  
   👉 [Register for a free OMDb account](https://www.omdbapi.com/apikey.aspx?__EVENTTARGET=freeAcct)
2. Select the free plan (`FREE`) and fill out the form
3. Activate api key by clicking the activation link sent to your email.
4. Copy your API key — you'll need it the first time you run the application.

---

### 4. Download the Movie Manager App

1. Download the latest version of the app:  
   👉 [Movie Manager - Download](https://drive.google.com/drive/folders/1oeKmlf5D7a8MvIudKcB2jwj2Rdl_dMkH?usp=sharing)
2. Unzip the downloaded `.rar` archive (you can use a tool like WinRAR or 7-Zip).
3. Run the `MovieManager.exe` file.

---

## 🚀 Launching the Application

1. When launching, you’ll be asked to provide:
   - **OMDb API Key** (from step 3)
   - **MySQL password**, which you set in step 2
2. The application will automatically connect to the database and fetch movie data.
3. All set! You can now search, add, and manage your collection 🎥

## 🛠️ Optional: Importing the Database

If you want to import a pre-made database for testing, follow these steps:
- Open the terminal and move to the directory where MySQL is installed, e.g.: C:\Program Files\MySQL\MySQL Server 8.0\bin
- Type the following command: mysql -u root -p < path_to_file/moviemanager_movies.sql
- Enter your MySQL password when prompted.

---

## ❓ Help

If you run into installation issues:
- Make sure .NET Runtime is installed (step 1)
- Check if the MySQL server is running and you entered the correct password
- Make sure your OMDb API key is activated

---
