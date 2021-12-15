## 责任链模式 Chain of Responsibility Pattern
- 定义：为请求创建了一个接收者对象的链。这种模式给予请求的类型，对请求的发送者和接收者进行解耦
- 意图：避免请求发送者与接收者耦合在一起，让多个对象都有可能接收请求，将这些对象连接成一条链，并且沿着这条链传递请求，直到有对象处理它为止。
- 职责链上的处理者负责处理请求，客户只需要将请求发送到职责链上即可，无须关心请求的处理细节和请求的传递，所以职责链将请求的发送者和请求的处理者解耦了。
- 责任链模式：[Chain Of Responsibility Pattern](https://github.com/jack-ningtz/DesignPattern/tree/main/ChainOfResponsibilityDesignPattern/ChainOfResponsibilityDesignPattern.cs "Chain Of Responsibility   Design")
