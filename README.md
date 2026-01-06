# 🛡️ FakeLetterGenerator

A high-performance C# console utility that transforms standard text and technical symbols into **Unicode Homoglyphs**. This tool is designed to bypass automated text checkers by replacing 100% of the input with visually identical but digitally unique "Ghost Characters."

## 🌟 Key Features

- **Total Tech Coverage**: Supports letters (A-Z), numbers (0-9), and all programming symbols (`{ }`, `[ ]`, `==`, `//`, `$`, `@`, etc.).
- **Anti-Detection Logic**: Replaces every character with a non-Latin counterpart, leaving no original "fingerprint" for scanners to detect.
- **Auto-Timestamping**: Every generation creates a unique file (e.g., `output_143025.txt`) to prevent data overwriting.
- **Smart IO**: Automatically detects if a folder exists and creates it if necessary.
- **Dynamic UI**: Features a colorful command-line interface with progress indicators and audio feedback.

## ⚙️ How It Works

The application maps standard ASCII characters to specific high-range Unicode blocks (Cyrillic, Greek, and Fullwidth). To a human, the text remains perfectly readable, but to a computer, the characters appear as entirely different symbols.

| Element Type | Example Input | FakeLetter Output |
| :--- | :--- | :--- |
| **Code Syntax** | `{ if (x == 1) }` | `｛ іｆ （х ＝＝ １） ｝` |
| **Plain Text** | `Password123` | `Раѕѕԝогԁ１２３` |

## 🚀 Getting Started

1. **Clone** the repository.
2. **Open** the solution in Visual Studio or your preferred C# IDE.
3. **Build and Run** the project.
4. **Input** your desired letters/code and the **save path**.
5. **Collect** your obfuscated `.txt` file from the destination folder.

## 📋 Technical Requirements

- **Runtime**: .NET Core 3.1 / .NET 5.0 / .NET 6.0 or higher.
- **Encoding**: Must be opened with UTF-8 compatible editors (VS Code, Notepad, etc.) to view correctly.

## 📸 Preview
<img width="1115" height="628" alt="Screenshot 2026-01-06 115340" src="https://github.com/user-attachments/assets/5056eec5-7bf6-4036-a84a-ffcbd36b5c86" />
