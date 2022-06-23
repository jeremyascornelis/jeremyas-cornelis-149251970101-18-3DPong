# DTS 3D Pong
## By: Jeremyas Cornelis Abigail
### ID Registrasi: 149251970101-18

Artikel ini akan berisi penjelasan seputar project 3D Pong ini.
Untuk build dari game ini dapat dilihat di [branch build](https://github.com/jeremyascornelis/jeremyas-cornelis-149251970101-18-3DPong/tree/build) pada repository ini

## Table of Contents

> 1. [Introduction](#1-introduction)
> 1. [Cara Bermain](#2-cara-bermain)
> 1. [Tentang Script](#3-scripts)


## 1. Introduction
Repository ini berisi permainan 3D Pong dalam rangka tugas untuk DTS FGA Agate Game Programming.
### Overview
- Aspect ratio layar adalah 4:3
- Permainan untuk 4 player local (seluruh pemain bermain dalam 1 device)
- End condition: permainan berakhir jika tersisa 1 player dalam permainan
- Progression of play: setiap player kebobolan, poin player tersebut bertambah 1. Jika poinnya mencapai 15, player tersebut keluar dari permainan. Selama belum tersisa 1 player saja, permainan terus berlangsung.
- Player action: pemain bisa menggeser-geserkan paddle ke kiri dan ke kanan
### Screen Flow
![image](https://user-images.githubusercontent.com/74807111/175260413-459d4931-ba07-4cfe-9de5-82f5f1f3cdde.png) <br>

**[⬆ Back to Top](#table-of-contents)**


## 2. Cara Bermain
Saya membagi beberapa poin penjelasan seputar cara bermain 3D Pong Game ini.
Penjelasan terkait cara bermain ini juga tersedia di dalam game, bila ingin melihatnya dapat menekan tombol How to Play.
### Tentang Paddle
- Paddle berwarna merah untuk player 1
- Paddle berwarna kuning untuk player 2
- Paddle berwarna hijau untuk player 3
- Paddle berwarna biru untuk player 4
### Tentang Movement
- Paddle merah bergerak ke kanan & kiri menggunakan → dan ←
- Paddle kuning bergerak ke kanan & kiri menggunakan D dan A
- Paddle hijau bergerak ke atas & bawah menggunakan ↑ dan ↓
- Paddle biru bergerak ke atas & bawah menggunakan W dan S
### Aturan Bermain
- Bola akan dispawn secara random dari 4 sudut arena
- Maksimum score dari masing-masing pemain adalah sejumlah 15.
- Bila pemain kemasukan bola maka score pemain akan bertambah.
- Pemain yang jumlah scorenya mencapai 15 akan dinyatakan kalah.
- Apabila pemain sudah kalah maka paddle dari pemain tersebut akan inaktif (tidak bisa digerakkan)
- Pemain yang dinyatakan sebagai pemenang adalah yang dapat bertahan hingga permainan berakhir. <br>

**[⬆ Back to Top](#table-of-contents)**


## 3. Scripts
Terdapat 13 Scripts yang dibutuhkan untuk membuat Game 3D Pong ini yang terdiri dari 4 scripts untuk paddle yang saya masukkan ke dalam folder Paddles dan 9 scripts yang lain untuk mengatur bola dan score. Berikut penjelasan detailnya:
### Paddles
- FirstPaddle.cs: script untuk mengontrol paddle berwarna merah
- SecondPaddle.cs: script untuk mengontrol paddle berwarna kuning
- ThirdPaddle.cs: script untuk mengontrol paddle berwarna hijau
- FourthPaddle.cs: script untuk mengontrol paddle berwarna biru
### Pembatas
- Pembatas.cs: script untuk membuat pembatas berupa silinder tetap diam dan tidak terpengaruh oleh efek bola ataupun paddle yang menabraknya.
### Ball
- BallController.cs: script untuk mengatur kecepatan bola dan menghapus object bola apabila menabrak tembok
- BallManager.cs: script untuk melakukan spawn random bola dari 4 sudut arena. Bila di dalam arena jumlah bola kurang dari 5 maka akan dilakukan spawan bola, namun bila sudah terdapat 5 bola dalam arena maka tidak akan dilakukan spawn
### Score & Goal
- ScoreManager.cs: script untuk mengatur perolehan score dari masing-masing pemain. Apabila pemain kebobolan maka pemain akan mendapatkan 1 poin. Pemain yang jumlah poinnya mencapai 15 akan dianggap kalah dan paddle nya akan dinonaktifkan. Apabila sudah tersisa 1 pemain maka akan memunculkan panel GameOver yang berisi pengumuman pemain yang memenangkan pertandingan.
- ScoreController.cs: script untuk mengubah text score UI pada layar menjadi lebih dinamis mengikuti pertambahan score yang terjadi selama permainan berlangsung.
- GoalController.cs: script untuk mengatur apabila bola mengenai tembok yang ada di salah satu sisi player maka itu akan menambah poin bagi player tersebut. Misalnya bila bola mengenai tembok di belakang paddle warna merah, maka poin player 1 akan bertambah sebagai bukti bahwa player tersebut telah kebobolan bola.
### GameOver
- GameOverManager.cs: script untuk mentrigger apabila telah tersisa satu pemain saja maka akan mengaktifkan panel GameOver dan memunculkan pemenang dari permainan ini. Serta terdapat method replay untuk kembali bermain lagi dan method MainMenu untuk kembali ke scene main menu.
### Scene Manager
- MainMenuManager.cs: script berisi beberapa method untuk mentrigger button sehingga dapat berpindah scene ke scene GamePlay ataupun ke scene HowtoPlay atau bahkan keluar dari aplikasi.
- HowToPlayManager.cs: script berisi method untuk tombol kembali ke main menu (berpindah ke scene main menu)<br>

**[⬆ Back to Top](#table-of-contents)**
