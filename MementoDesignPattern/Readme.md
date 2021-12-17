## 备忘录模式 Memento Pattern
- 保存一个对象的某个状态，以便在适当的时候恢复对象。
- 在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态。
- 备忘录模式能记录一个对象的内部状态，当用户后悔时能撤销当前操作，使数据恢复到它原先的状态。

- 备忘录模式：[Memento Patttern](https://github.com/jack-ningtz/DesignPattern/tree/main/MementoDesignPattern/MementoDesignPattern.cs "Memento  Design")

## 结构
- 发起人（Originator）角色：记录当前时刻的内部状态信息，提供创建备忘录和恢复备忘录数据的功能，实现其他业务功能，它可以访问备忘录里的所有信息。
- 备忘录（Memento）角色：负责存储发起人的内部状态，在需要的时候提供这些内部状态给发起人。
- 管理者（Caretaker）角色：对备忘录进行管理，提供保存与获取备忘录的功能，但其不能对备忘录的内容进行访问与修改。

- Originator 创建并在 Memento 对象中存储状态。Caretaker 对象负责从 Memento 中恢复对象的状态。