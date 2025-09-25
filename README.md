# WinForms Dictionary Application

## About The Project

"Dictionary" is a desktop application for Windows, developed using C# and WinForms. It allows users to create their own custom dictionaries for any language, add words with translations, group them by topics, and test their knowledge with a built-in quiz feature.

<img width="1634" height="764" alt="Скрин словарь 1" src="https://github.com/user-attachments/assets/c5efe43f-9bae-435d-baa6-08b5d28b00b7" />
<img width="1634" height="899" alt="Скрин словарь 2" src="https://github.com/user-attachments/assets/19560fdf-40f1-4b3a-95c3-40753efd142d" />

This project demonstrates skills in WinForms UI development, local file I/O for data persistence, implementation of CRUD operations, and the creation of interactive user scenarios.

## ⚙️ Features

*   **Dictionary Creation:** Users can create new dictionaries for any language pair (e.g., English-Russian).
*   **Word Management:** Full CRUD (Create, Read, Update, Delete) support for words and their translations.
*   **Topic-Based Grouping:** Ability to group words by topics for structured learning.
*   **Pagination:** Long lists of words are displayed using a paginated view for easy navigation.
*   **Interactive Quiz:** A built-in test mode to check knowledge. The quiz randomly selects words and provides multiple-choice answers.
*   **User-Friendly UI:** The application features an intuitive menu and supports hotkeys for quick access to functions.

## 🛠️ Tech Stack

*   **Language:** C#
*   **Platform:** .NET Framework
*   **UI:** Windows Forms (WinForms)
*   **Data Storage:** A custom text-based format was implemented for saving and loading dictionaries. This includes a self-developed parser and serializer for file operations, demonstrating a deep understanding of data handling.
*   **Design Patterns:**
    *   **Factory Pattern:** Implemented in `DictionaryManagerFactory.cs` to create dictionary management instances.
    *   **Repository Pattern:** Implemented in `DictionaryRepository.cs` to abstract data access logic.

---

<details>
# Приложение-словарь (C# / WinForms)

### Курсовой проект по разработке десктопных приложений на C#

<summary>🇷🇺 Русская версия</summary>
## О проекте

"Словарь" — это десктопное приложение для Windows, разработанное на C# и WinForms. Оно позволяет пользователям создавать собственные словари на любых языках, добавлять слова с переводами, группировать их по темам и проверять свои знания с помощью встроенного теста.

Проект демонстрирует навыки разработки UI на WinForms, работы с локальными файлами для хранения данных, реализации CRUD-операций и создания интерактивных пользовательских сценариев.

## ⚙️ Функционал

*   **Создание словарей:** Пользователь может создать новый словарь для любой языковой пары (например, Английский-Русский).
*   **Управление словами:** Полная поддержка CRUD-операций (Создание, Чтение, Обновление, Удаление) для слов и их переводов.
*   **Тематические группы:** Возможность группировать слова по темам для удобства изучения.
*   **Пагинация:** Просмотр длинных списков слов реализован с разбивкой на страницы.
*   **Интерактивное тестирование:** Встроенный режим теста для проверки знаний, который случайным образом выбирает слова и предлагает варианты ответов.
*   **Пользовательский интерфейс:** Приложение имеет интуитивно понятное меню и поддерживает горячие клавиши для быстрого доступа к функциям.

## 🛠️ Стек технологий

*   **Язык:** C#
*   **Платформа:** .NET Framework (или .NET, в зависимости от версии)
*   **UI:** Windows Forms (WinForms)
*   **Хранение данных:** Реализован **кастомный текстовый формат** для сохранения и загрузки словарей, включая разработку собственного **парсер-сериализатора** для работы с файлами.
*   **Архитектурные паттерны:** Factory (`DictionaryManagerFactory.cs`), Repository (`DictionaryRepository.cs`).
</details>
