## 代理模式 Proxy Pattern
- 一个客户不能或者不想直接访问另一个对象，这时需要找一个中介帮忙完成某项任务，这个中介就是代理对象

### 实现
- 通过定义一个继承抽象主题的代理来包含真实主题，从而实现对真实主题的访问

### Proxy VS Adapter VS Decorator
- 和适配器模式的区别：适配器模式主要改变所考虑对象的接口，而代理模式不能改变所代理类的接口
- 和装饰器模式的区别：装饰器模式为了增强功能，而代理模式是为了加以控制

- 代理模式：[Proxy Patttern](https://github.com/jack-ningtz/DesignPattern/tree/main/ProxyDesignPattern/ProxyPattern.cs "Proxy  Design")
- 动态代理：[Dynamic Proxy Patttern](https://github.com/jack-ningtz/DesignPattern/tree/main/ProxyDesignPattern/DynamicProxy.cs "Dynamic Proxy  Design")