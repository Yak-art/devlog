# DevLog

DevLog — это персональная система учёта рабочих активностей разработчика:
задачи, затраченное время, ежедневные и недельные итоги.

## Цель проекта
Создать учебный full-stack проект с упором на:
- ASP.NET Core
- Next.js
- Clean Architecture
- Docker
- CI/CD (GitHub Actions)

## Основной функционал (MVP)
- Регистрация и авторизация пользователей
- Учёт активностей (работа, обучение, личное)
- Трекинг времени
- Дневные и недельные отчёты

## Технологический стек

### Backend
- ASP.NET Core
- Entity Framework Core
- PostgreSQL
- JWT Authentication

### Frontend
- Next.js
- TypeScript
- Tailwind CSS

### Infrastructure
- Docker
- Docker Compose
- GitHub Actions

## Архитектура
Backend реализован по принципам Clean Architecture:
- Domain
- Application
- Infrastructure
- API
