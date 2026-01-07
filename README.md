# MiniDARMAS
Digital Meeting Recording and Transcript Management (MiniDARMAS)

## Summary
MiniDARMAS is a lightweight Windows desktop application for managing meeting recordings, assigning recordings, and editing/viewing transcriptions. It provides user authentication, a central dashboard, meeting and transcription forms, and simple validation helpers.

## Tech stack
- C# 7.3
- .NET Framework 4.8
- Windows Forms (WinForms)
- Developed with __Visual Studio 2022__

Project layout (key files)
- `MiniDARMAS\LoginForm.cs`, `LoginForm.Designer.cs` — user authentication UI
- `MiniDARMAS\DashboardForm.cs`, `DashboardForm.Designer.cs` — main application dashboard
- `MiniDARMAS\MeetingForm.cs` — meeting/recording details UI
- `MiniDARMAS\TranscriptionForm.cs` — transcription editor/viewer
- `MiniDARMAS\AssignedRecordingsForm.cs` — recordings assigned to users
- `MiniDARMAS\Data\AssignmentData.cs` — simple data helper / data model
- `MiniDARMAS\Validation.cs` — input validation helpers

## Features
- User login and basic authentication flow
- Dashboard for quick access to meetings and assigned recordings
- Create and manage meeting records
- Assign recordings to users
- View and edit transcriptions
- Simple validation helpers for form inputs

## Prerequisites
- Windows 10/11
- __Visual Studio 2022__ (with .NET desktop development workload)
- .NET Framework 4.8 Developer Pack

## Build & run
1. Clone the repository:
   - git clone https://github.com/rodas-awgichew/MiniDARMAS-Digital-Meeting-Recording-and-Transcript-Management.git
2. Open the solution in __Visual Studio 2022__ (use __File > Open > Project/Solution__).
3. Restore NuGet packages if prompted.
4. Build the solution via __Build > Build Solution__.
5. Run the app with __Debug > Start Debugging__ (F5) or __Start Without Debugging__ (Ctrl+F5).

## Configuration
- Review `MiniDARMAS\Data\AssignmentData.cs` for where and how data is stored/managed. Adjust persistence or connection settings as needed.
- Add secure credential storage and proper persistence before production use.

## Contributing
- Fork the repo, create a branch for your feature/fix, commit, and open a pull request.
- Keep changes small and focused. Include a brief description of the change and any setup steps.

## License
Specify a license (e.g., MIT) in `LICENSE` if you intend to open-source.

## Contact
For questions or contributions, open an issue or submit a pull request on the repository.
