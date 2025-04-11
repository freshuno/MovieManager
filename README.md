# 🎬 Movie Manager

Movie Manager to aplikacja desktopowa do zarządzania własną kolekcją filmów, korzystająca z bazy danych MySQL oraz zewnętrznego API OMDb do pobierania informacji o filmach i serialach.

---

## ⚙️ Wymagania systemowe

- Windows 10/11 (x64)
- Połączenie z internetem (do pobierania danych z OMDb API)

---

## ✅ Instalacja krok po kroku

### 1. Zainstaluj .NET Runtime

Aby uruchomić aplikację, zainstaluj .NET Desktop Runtime 9.0.4:

👉 [Pobierz instalator](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-desktop-9.0.4-windows-x64-installer?cid=getdotnetcore)

> ⚠️ Uwaga: Jeśli pojawi się błąd podczas instalacji MySQL, spróbuj najpierw zainstalować ten Runtime.

---

### 2. Zainstaluj MySQL Server

1. Pobierz instalator MySQL Server:
   👉 [MySQL Download](https://dev.mysql.com/downloads/mysql/)
2. Podczas instalacji możesz zostawić ustawienia domyślne.
3. **Zapamiętaj hasło**, które ustawisz dla użytkownika `root` — będzie potrzebne przy uruchamianiu aplikacji.

---

### 3. Wygeneruj darmowy klucz OMDb API

1. Wejdź na stronę:  
   👉 [Zarejestruj darmowe konto OMDb](https://www.omdbapi.com/apikey.aspx?__EVENTTARGET=freeAcct)
2. Wypełnij formularz, wybierając darmowy plan (`Free`).
3. Potwierdź rejestrację, klikając link aktywacyjny, który otrzymasz na maila.
4. Skopiuj swój klucz API — będzie potrzebny przy pierwszym uruchomieniu aplikacji.

---

### 4. Pobierz aplikację Movie Manager

1. Pobierz najnowszą wersję aplikacji:  
   👉 [Movie Manager - Download](https://shorturl.at/Z9gdd)
2. Rozpakuj pobrane archiwum `.rar`.
3. Uruchom plik `MovieManager.exe`.

---

## 🚀 Uruchomienie

1. Przy pierwszym uruchomieniu zostaniesz poproszony o podanie:
   - **API Key** z OMDb (z kroku 3)
   - **Hasła do MySQL**, które ustawiłeś w kroku 2
2. Aplikacja automatycznie połączy się z bazą danych i pobierze dane o filmach.
3. Gotowe! Możesz przeszukiwać, dodawać i zarządzać własną kolekcją 🎥

---

## ❓ Pomoc

W przypadku problemów z instalacją:
- Upewnij się, że masz zainstalowany .NET Runtime (krok 1)
- Sprawdź, czy serwer MySQL działa i masz poprawne hasło
- Sprawdź, czy klucz OMDb API jest aktywowany

---

