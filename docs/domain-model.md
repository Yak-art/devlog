# Domain Model

## User
- Id (Guid)
- Email
- PasswordHash
- CreatedAt

## Activity
- Id (Guid)
- UserId
- Title
- Description
- Type (Work | Study | Personal)
- Date

## TimeEntry
- Id (Guid)
- ActivityId
- StartTime
- EndTime
- Duration
