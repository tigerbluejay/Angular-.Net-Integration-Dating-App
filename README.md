# 💘 DatingApp

A full-stack dating web application built with ASP.NET 8 Web API and Angular 18. Users can register, login, view and filter profiles, exchange messages in real-time, and manage photos. Admin users can moderate photos and manage user roles.

##🚀 Features
### ✅ User Registration & Login
- Secure authentication using JWT tokens
- Role-based authorization (Admin / Member)

### ✅ Profile Management
- View other user profiles (latest active first)
- Filter users by gender and age
- Like/unlike users and see who liked you
- Edit own profile, upload/delete photos, set main photo
- Pagination for efficient browsing

### ✅ Messaging
- Real-time chat using SignalR
- Messages marked as read/unread
- Notifications for new messages

### ✅ Admin Tools
- Approve or reject submitted profile photos
- Manage user roles (promote/demote users)

### ✅ User Experience
- Toaster notifications for actions and updates
- Confirmation modals for critical actions
- Unsaved changes guard for profile editing
- See users currently online

## 🛠 Tech Stack
ASP.NET 8 Web API	Angular 18	SignalR	SQLite	JWT tokens

##  🗂 Project Structure
### API (/demo/DatingApp/API)
Controllers/ → REST API controllers: UsersController, LikesController, MessagesController, AdminController, etc.
Data/ → EF Core DbContext (DataContext.cs), Repositories, Seed data
Entities/ → Domain models: AppUser, Photo, Message, UserLike, AppRole
DTOs/ → Data transfer objects: MemberDTO, MessageDTO, PhotoDTO, etc.
SignalR/ → SignalR hubs: MessageHub, PresenceHub
Services/ → TokenService, PhotoService
Helpers/ → Pagination, AutoMapper profiles, custom params classes
Middleware/ → ExceptionMiddleware

### Client (/demo/DatingApp/client)
src/app/admin/ → Admin panel + photo/user management
src/app/members/ → Member list, details, edit, messages, photo editor
src/app/messages/ → General messaging components
src/app/lists/ → Liked users / users who liked you
src/app/modals/ → Confirmation dialogs, roles modals
src/app/nav/ → Top nav component
src/app/_guards/ → Route guards (auth, admin, unsaved changes)
src/app/_services/ → Angular services (account, members, admin, messages, presence)
src/app/_interceptors/ → JWT, error, loading interceptors
src/app/_models/ → Interfaces for User, Photo, Message, etc.
src/app/_forms/ → Shared form components (text input, date picker)
src/app/errors/ → Error components (404, server error, test errors)
src/app/home/, src/app/register/ → Home + register views
environments/ → API base URL config
assets/ → Static assets

## ⚙ Getting Started
Prerequisites
- .NET 8 SDK
- Node.js (18+) + NPM
- Angular CLI
- SQLite

### Clone & Setup
```bash
git clone <your-repo-url>
cd <your-repo-folder>
```

### API Setup
```bash
cd demo/DatingApp/API
dotnet restore
dotnet ef database update
dotnet run
```
API runs at: https://localhost:5001/

Angular Client Setup

```bash
cd demo/DatingApp/client
npm install
ng serve --open
```
Client runs at: http://localhost:4200/

## ⚡ Usage
- Register/Login: Create a new user or login as existing user.
- Filter users: By gender, age range.
- Like users: See liked / liked-by lists.
- Edit profile: Update details, upload photos (choose main photo).
- Messaging: Chat in real-time; notifications on new messages.
- Admin: Approve photos, assign/remove roles.
- Modals/Toasts: User-friendly notifications and confirmations.

## 🔐 Security
- JWT Bearer tokens for API calls
- Role-based access control for admin actions
- SignalR with token auth
- Client-side guards for protected routes
- Server-side file validation for image uploads

### 💡 Development Notes
- API uses EF Core Code First migrations
- Angular uses interceptors for error handling, loading indicators, and JWT injection
- SignalR tracks online presence and delivers real-time notifications
- Paged lists implemented for scalability
