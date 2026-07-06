# TaskProgresser 🚀

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat&logo=dotnet)
![WinForms](https://img.shields.io/badge/WinForms-Framework_4.8-blue?style=flat&logo=windows)
![MySQL](https://img.shields.io/badge/MySQL-Cloud_Aiven-4479A1?style=flat&logo=mysql)
![Render](https://img.shields.io/badge/Deployed_on-Render-46E3B7?style=flat)

TaskProgresser is a distributed, cloud-based task management ecosystem designed to combat "time blindness." Instead of traditional static deadlines, the system mathematically normalizes time perception by converting deadlines into **dynamic progress percentages**, providing continuous background monitoring.

## 📸 Interface Showcase

<img width="666" height="481" alt="image" src="https://github.com/user-attachments/assets/8081a8b0-f847-4103-b9dc-af3a89166736" />
<img width="666" height="481" alt="image" src="https://github.com/user-attachments/assets/87bc7a87-bfcf-4162-9091-472817dfea01" />
<img width="666" height="481" alt="image" src="https://github.com/user-attachments/assets/194ab4ef-ad4d-4e02-9fd2-7444f13419b2" />
<img width="766" height="773" alt="image" src="https://github.com/user-attachments/assets/96709503-44ce-44ed-8815-81f6f0241934" />
<img width="297" height="337" alt="image" src="https://github.com/user-attachments/assets/be09dca2-2fc4-4144-abb5-9aafda434649" />
<img width="420" height="140" alt="image" src="https://github.com/user-attachments/assets/e4e4f352-aeae-4873-bf87-f2e6a6880e4e" />


## ✨ Key Features

* **Dynamic System Tray Integration:** Generates native, live-updating progress percentage icons directly in the Windows taskbar, utilizing low-level Win32 API capabilities.
* **Fly-out Windows:** Custom, borderless pop-ups providing instant access to task details without opening the main application window.
* **Stateless REST API:** A fully decoupled backend architecture ensuring high scalability and global availability.
* **JWT-Based Security:** Secure multi-user environment with token-based authentication and isolated data spaces.
* **Analytics Module:** Automated aggregation of personal productivity metrics (success rates, overtime completion, active processes).

## 🛠 Tech Stack & Architecture

The project strictly follows a 3-tier Client-Server architecture, ensuring a clear separation of concerns:

### Client Application (Presentation Layer)
* **Framework:** C# / .NET Framework 4.8 (Windows Forms)
* **Why WinForms?** Chosen specifically for its deep, native integration with the Windows OS `NotifyIcon` component and minimal RAM consumption (~15-20 MB) during 24/7 background execution.
* **Logic:** Implements the **Observer pattern** for synchronized timer updates and performs local mathematical modeling of time interpolation to minimize network overhead.

### Shared Core (Domain Layer)
* **Framework:** .NET Standard 2.0
* **Responsibilities:** Houses Data Transfer Objects (DTOs), Domain Models, and shared Static Validation Services (e.g., `AuthValidator`) to maintain the DRY (Don't Repeat Yourself) principle across client and server.

### Server Backend (Business & Data Layer)
* **Framework:** ASP.NET Core 8.0 Web API
* **Database:** MySQL (Cloud-hosted on Aiven)
* **ORM:** Entity Framework Core (Code-First approach with Migrations)
* **Infrastructure:** Dockerized and continuously deployed (CI/CD) on Render.com. All sensitive configurations are managed via Environment Variables.

## 🚀 Getting Started

### Prerequisites
* .NET 8.0 SDK (for API)
* .NET Framework 4.8 Runtime (for Client)
* MySQL Server instance
