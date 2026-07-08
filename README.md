# Unity-Demo-RollABall
Unity 入门物理小游戏 Demo，基于官方RollABall拓展完整游戏逻辑。

## 实现功能
1. 物理系统：Rigidbody刚体、碰撞器、触发拾取分离逻辑
2. 输入控制：WASD按键给小球施加力实现平面移动
3. 跟随相机：脚本控制相机同步小球位移
4. 资源复用：食物预制体Prefab，脚本控制持续自转
5. 交互逻辑：OnTriggerEnter拾取食物、UGUI实时更新分数
6. 胜利判定：收集全部食物触发胜利逻辑
7. 场景搭建：地面材质、边界围墙、基础光照渲染

## 运行方式
1. 使用对应版本Unity打开项目根目录
2. 打开 Assets/Scenes/Main 场景，点击Play运行

## 技术栈
C# 脚本开发 | Unity物理引擎 | Prefab预制体 | UGUI界面 | 碰撞/触发检测
