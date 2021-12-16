## 命令模式 Command Pattern
- 定义：种数据驱动的设计模式，它属于行为型模式。请求以命令的形式包裹在对象中，并传给调用对象。调用对象寻找可以处理该命令的合适的对象，并把该命令传给相应的对象，该对象执行命令.
- 意图：将一个请求封装成一个对象，从而使您可以用不同的请求对客户进行参数化。
- 在软件系统中，行为请求者与行为实现者通常是一种紧耦合的关系，但某些场合，比如需要对行为进行记录、撤销或重做、事务等处理时，这种无法抵御变化的紧耦合的设计就不太合适。
- According to Gang of Four (GoF) definitions, the Command Design Pattern is used to encapsulate a request as an object (i.e. a command) and pass to an invoker, wherein the invoker does now knows how to service the request but uses the encapsulated command to perform an action. (根据四人组(GoF)的定义，命令设计模式用于将请求封装为一个对象(即命令)并传递给调用者，其中调用者现在知道如何为请求服务，但使用封装的命令来执行操作。)

- 命令模式：[Command Pattern](https://github.com/jack-ningtz/DesignPattern/tree/main/CommandDesignPattern/CommandDesignPattern.cs "Command  Design")