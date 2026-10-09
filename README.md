# Практическое занятие №5

## Цель работы
Изучение и практическое освоение системы контроля версий, настройки репозитория, фильтрации файлов, внесения изменений, восстановления проекта и просмотра истории.

## Используемые технологии
- Visual Studio
- C#
- Git
- GitHub
- Subversion
- Mercurial

## Структура проекта

- **PRACTICE_5.md**: Описание проекта.
- **Models/Student.cs**: Класс Student для демонстрации изменений.
- **.gitignore**: Файл для исключения ненужных файлов из Git.
- **.gitattributes**: Файл для настройки атрибутов Git.
- **README.md**: Основной файл с описанием проекта и выполненных операций.
- **REPORT_PRACTICE_5.md**: Отчёт о выполненной работе.

## Выполненные операции

### 1. Настройка подключения к репозиторию

```bash
git config --global user.name "Ваше Имя"
git config --global user.email "your_email@example.com"

cd путь/к/проекту

git init
git add .
git commit -m "Initial commit"

git remote add origin https://github.com/shadowbreaker/-5.git
git branch -M master
git push -u origin master

git remote -v
git status