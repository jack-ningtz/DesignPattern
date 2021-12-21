## 工厂模式 Factory Patttern
- According to Gang of Four, the Factory Design Pattern states that “A factory is an object which is used for creating other objects”. (工厂是一个创建其他对象的对象)
- 在工厂模式中，我们在创建对象时不会对客户端暴露创建逻辑，并且是通过使用一个共同的接口来指向新创建的对象。
- 定义一个创建对象的接口，让其子类自己决定实例化哪一个工厂类，工厂模式使其创建过程延迟到子类进行。
- 工厂模式的定义：定义一个创建产品对象的工厂接口，将产品对象的实际创建工作推迟到具体子工厂类当中。这满足创建型模式中所要求的“创建与使用相分离”的特点。
- 工厂模式: [Factory Patttern](https://github.com/jack-ningtz/DesignPattern/tree/main/FactoryDesignPattern/FactoryDesignPattern.cs "Factory  Design")
## 分类
- 按实际业务场景划分，工厂模式有 3 种不同的实现方式，分别是简单工厂模式、工厂方法模式和抽象工厂模式。
- 我们把被创建的对象称为“产品”，把创建产品的对象称为“工厂”。如果要创建的产品不多，只要一个工厂类就可以完成，这种模式叫“简单工厂模式”。

