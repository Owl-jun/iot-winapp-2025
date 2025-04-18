# iot-winapp-2025
IoT 개발자 C#/WinApp 리포지토리 2025

## 1일차

### C# 시작전에
- Visual Studio Installer 확인

    - ASP.NET 및 웹 개발, .NET 데스크톱 개발 필수
    - .NET Multi-Platform App UI 개발
    
    <img src="./image/cs0001.png" width = 700>

### C# 학습

#### C#이란?
- C# : **마이크로소프트**가 개발한 객체지향 프로그래밍 언어
    - 1991년, 귀도 반 로섬이 Python을 개발 (1989년 시작)
    - 1985년, 비야네 스트롭스트룹이 C++을 개발(너무 어려움, 1980년 초반 개발시작)
    - 1995년, 제임스 고슬링이 Java를 개발(C++의 문법을 기반, 좀 더 쉬운 언어, 1991년 개발 시작)
    - MS가 썬 마이크로시스템즈와 라이센스 채결 후 MS용 Java인 J++를 개발. 특허권 소송 발생
    - 1999년, 파스칼, 델파이를 개발한 `앤더스 헤일스버그`가 C++, Java를 기반으로 C#을 개발
    - 2000년, C# 발표
    - 2025년, C# 13.0

- C# 특징
    - 닷넷 플랫폼 위에서 동작(Managed C++, C#, Java, Python, ...)
    - 문법이 Java와 상당히 유사. C/C++ 보다 언어 난이도가 낮음
    - Java와 달리 unsafe mode를 사용하면 C/C++ 포인터기능을 사용 가능
    - 런타임 시 쓰레기 수집(**Garbage Collection**)으로 자동 메모리 관리

- C# 유우머
    - 1999년 앤더스 헤일스버그가 최초 이름을 Cool(C-like Object Oriented Language)로 이름을 생성
    - 상표 문제로 C#으로 변경
    - C#의 의미는 C++보다 개선된 언어의 의미로 C++++, 또는 음악에서 #이 원음보다 반음 높다.

- C# 버전
    - C# 1.x(.NET Framework 1.x) - 2002 ~ 2003년, 문제 많음 
    - C# 2.x(.NET Framework 2.x) - 2006년, 개선이 많이 됨
    - C# 3.x(.NET Framework 2.x~3.5) - 2007년, Java와 차이가 많아짐
    - C# 4.x(.NET Framework 4.x) - 2010년, C#의 기반
    - ...
    - C# 6.x(.NET Framework 4.6, .NET Core 1.x) - 2015년
    - C# 7.x(.NET Framework 4.7, .NET Core 2.x) - 2017~2018년
    - ...
    - C# 9.0(.NET 5.0) - 2020년
    - C# 10.0(.NET 6) - 2021년 
    - C# 11.0(.NET 7) - 2022년
    - C# 12.x(.NET 8) - 2023년
    - C# 13.x(.NET 9) - 2024년 11월

- 호환성, 범용성
    - 초기 Windows OS에서만 동작, OS플랫폼 독립적인 Java보다 범용성이 낮았음
    - 2016년 부터 Linux 공식 지원, macOS에서도 사용가능. 오픈소스 공표
    - 유니티 엔진 기본언어, Xamarin(이후 MAUI로 변경)로 모바일 개발 가능
    - 리눅스 Mono라는 닷넷 개발 프로젝트 -> 후에 MS에 흡수됨

#### .NET Framework (.NET)
- CLR(Common Langauage Runtime) 클래스를 사용하는 가상 머신, 예로 C#, Java 동시개발 가능
- Java의 JVM과 유사한 개념
- 언어가 발전하면서 필요한 기능이 늘기 때문에 .NET Framework도 버전업을 계속
- 2016년 리눅스 지원 개발시부터, .NET Framework가 너무 윈도우 구조에 토착되다 보니 새로운 프레임워크가 필요해짐
- .NET Core : 리눅스 지원용으로 만든 .NET Framework 
- .NET Core와 .NET Framework 가 혼용
- 2020년 .NET Core와 .NET Framework를 통합해서 .NET 5.0 공표. 이 이후부터 그냥 .NET으로 불림
- C# 버전과 .NET 버전 숫자 차이나기 시작

- .NET 데스크톱 개발을 설치하면 C#, Visual Basic, F# 등 여러언어를 사용 가능

- C# 12.0, .NET 8 , Visual Studio 2022 Community Edition에서 학습


## 2일차
- WinApp으로 문법 학습, 문법 학습 후 WPF로 이전

### C# 문법

## 10일차

### 코딩테스트