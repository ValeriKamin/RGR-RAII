## 🔷 1. RAII (Resource Acquisition Is Initialization)
**Тип:** Creational  
**Призначення:** Автоматичне захоплення та звільнення ресурсу у конструкторі/деструкторі.  

### UML - класів
```mermaid
classDiagram
    class ResourceHandler {
        -resource: string
        +ResourceHandler()
        +Dispose()
    }
```

### UML - послідовності
```mermaid
sequenceDiagram
    participant Main
    participant ResourceHandler
    Main->>ResourceHandler: new ResourceHandler()
    ResourceHandler-->>Main: ресурс захоплено
    Main->>ResourceHandler: Dispose()
    ResourceHandler-->>Main: ресурс звільнено
```
