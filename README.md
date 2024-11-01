# KoreanLicensePlateRecognition

## 1. 프로젝트 개요
한국 차량번호판 인식기 서버 프로그램을 구현하기 위해 추천드리는 플랫폼은 ASP.NET Core입니다. 
이는 Windows Server에서도 안정적으로 구동할 수 있으며, 비동기 프로그래밍 및 의존성 주입(DI) 등 
현대적 서버 개발에 유리한 환경을 제공합니다. 프로젝트 구조를 계층화하여 관리하기 쉽게 만들고, 
SOLID 원칙을 지키도록 설계하겠습니다.


## 2. 프로젝트 구조
KoreanLicensePlateRecognition
├── Controllers
├── Services
├── Repositories
├── Models
│   ├── DTOs
│   └── Entities
├── Data
├── Interfaces
└── Utils

---
Controllers: API 엔드포인트를 관리합니다.
Services: 비즈니스 로직을 처리합니다.
Repositories: 데이터베이스와의 직접적인 상호작용을 담당합니다.
Models: DTOs(데이터 전송 객체)와 Entities(데이터베이스 엔터티)로 나눠 관리합니다.
Data: 데이터베이스 컨텍스트와 초기 설정을 관리합니다.
Interfaces: DI를 위한 인터페이스를 정의합니다.
Utils: 유틸리티와 공용 기능을 위한 폴더입니다.

---

## 3. 프로젝트 설정

```shell
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.Extensions.DependencyInjection
Install-Package Microsoft.EntityFrameworkCore.Tools
```

