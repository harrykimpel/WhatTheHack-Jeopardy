# WhatTheHack - Jeopardy

![What The Hack - Jeopardy](./wwwroot/images/WTH-Jeopardy.png)

## Prerequisites

- .NET SDK 10.0 (or later)
- Optional: Visual Studio 2022/2025 or VS Code with the C# Dev Kit

## Getting Started

1. Open a terminal in this folder.
2. Restore dependencies:
	 ```bash
	 dotnet restore
	 ```
3. Run the app:
	 ```bash
	 dotnet run
	 ```
4. Open the URL shown in the terminal (typically `https://localhost:7xxx`).

## Customizing the Game

- Questions and answers live in [wwwroot/data/jeopardy-board.json](wwwroot/data/jeopardy-board.json).
	- Prompts are the on-screen clues.
	- Answers are the responses players should phrase as a question.
- Initial team names live in [wwwroot/data/teams.json](wwwroot/data/teams.json).

## Game Controls

- Use **New Game** to reset teams and the board.
- Select a tile to reveal the clue.
- Use **Show Answer** to reveal the response.
- Use the scoring buttons to award or deduct points.

## Troubleshooting

- If the HTTPS dev certificate is missing, run:
	```bash
	dotnet dev-certs https --trust
	```
