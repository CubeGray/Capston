# Decrescendo

## Explanation ([Video](https://www.youtube.com/watch?v=ag66wZfQqsU))
3D로 모델링 된 가구를 직접 배치하여 자신의 집을 커스터마이징 하는 사이트로 실제 가구를 배치한 후 예상되는 모습을 간접 체험해볼 수 있는 프로그램입니다. 비슷한 디자인을 가진 가구들의 가격을 비교할 수 있으며 회사별, 종류별로 가구를 선택할 수 있습니다. 
프로그램 사용자는 인테리어를 하는 과정에서 간단한 방법으로 시각화를 할 수 있으며 가격 비교를 통해 합리적인 소비를 할 수 있을 것이라는 기대효과가 있습니다.

## Dev
1. Unity : 가구를 배치해 볼 수 있는 프로젝트를 제작 후 WebGL로 빌드하여 Web에서 구동
-> Unity에서는 JavaScript코드를 Plugins에 포함시켜 Web에 Json데이터를 전송했고, Web에서는 SendMessage를 사용해서 Unity에 Json데이터를 전송함.
2. Spring : 프레임워크를 사용하여 Web 개발을 효율적으로 개발
3. Mybatis : DB접근에 있어, 편의성 및 간결성을 보장
4. Ajax : 비동기방식으로 가구선택 및 배치기능을 one page로 구현
5. Data crawling : Jsoup 라이브러리를 활용하여 실제 가구정보(가구명, 색, 제조사, 가격, 사이즈)를 수집함. 
6. DataBase(MySQL) : 이전에 작업했던 인테리어의 모든 정보(위치 좌표, 각도, 크기)를 Json으로 변환하여 DB에 저장하였고 불러올 때는 이 데이터를 이용해 객체를 reload하여 화면에 띄워줌
7. ERD : Erwin을 이용하여 Entity-Relationship 설계

<br>
<br>

**홈 화면**
<br>
<center><img src="https://user-images.githubusercontent.com/43517509/93279627-b34ccf80-f802-11ea-81b5-fd9bef81b6b3.PNG" width="800" height="500"></center>
<br>

**로그인 화면**
<br>
<center><img src="https://user-images.githubusercontent.com/43517509/93279655-c2cc1880-f802-11ea-9a74-754729ba3632.PNG" width="800" height="500"></center>
<br>

**가구 리스트 화면**
<br>
<center><img src="https://user-images.githubusercontent.com/43517509/93279664-c6f83600-f802-11ea-8ca6-c371770be568.png" width="800" height="500"></center>
<br>

**장바구니 화면**
<br>
<center><img src="https://user-images.githubusercontent.com/43517509/93279670-c8c1f980-f802-11ea-82f0-4e4f7f23876e.png" width="800" height="500"></center>
<br>

**가구 배치 후 바닥 재질 선택 화면**
<br>
<center><img src="https://user-images.githubusercontent.com/43517509/93279678-ccee1700-f802-11ea-9438-fe2961eb8e79.PNG" width="800" height="500"></center>
<br>

**배치 완료된 방 3D 시점 화면**
<br>
<center><img src="https://user-images.githubusercontent.com/43517509/93279691-d6777f00-f802-11ea-9d54-aecdc1e87457.PNG" width="800" height="500"></center>
