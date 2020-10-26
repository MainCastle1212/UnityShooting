# UnityShooting
## 概要
遠い昔、はるか彼方の銀河系で……  
恒星間航行中の超大型宇宙船が進路を誤って小惑星帯に迷い込んでしまった  
迫りくる小惑星を破壊し母艦を守れ  
#### 自機
![idle_player_upgrade1](https://user-images.githubusercontent.com/66996129/96333582-c2df6280-10a5-11eb-9dde-bac90fa2ab0e.png)　HP: 10  
#### 小惑星
![SoulFragment](https://user-images.githubusercontent.com/66996129/96333647-249fcc80-10a6-11eb-9b3e-3931c163b546.png)  
#### エネルギー
![BulletBombSpriteSheetBlue](https://user-images.githubusercontent.com/66996129/96333612-f0c4a700-10a5-11eb-932d-d8f3d4a55523.png)


## 基本操作
* A/Dか左右キーで移動
* スペースキーで弾を発射
* エネルギーを1つ消費しQでオールエネミーデストロイコードを発動
* エネルギーが3つある状態でEキー入力でビームを発射

## ルール
* 自機かマザーシップが壊れるとゲームオーバー
* 小惑星と接触するとHPが減る  
* 落ちてくる小惑星を破壊する
* 破壊するとポイント加算

## そのほか
* エネルギーは当たることで最大3つまで取得できる　　

## ゲームループ
タイトル画面  
　　↓  
ゲーム画面 → ポーズ画面 → ゲーム終了  
　　↓  
ゲームオーバー画面 → リトライ → ゲーム画面  


2020/10/12 一部機能変更  
* 爆弾の仕様の変更を行いました
* ポーズ画面からゲーム終了を行うようにしました  
2020/10/17 仕様変更
* 爆弾からエネルギーに変更を行いました
* エネルギーを消費してビームを発動できるようにしました
