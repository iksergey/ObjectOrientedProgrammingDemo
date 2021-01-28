using System;

class AccessModifiersDemo
{

    /// public - неограниченный доступ. Есть возможность обратиться откуда угодно
    public int PublicProperty { get; set; }

    /// private - доступ ограничен содержащим типом. Есть возможность обратиться только из самого типа
    private int PrivateProperty { get; set; }

    /// protected - доступ ограничен содержащим классом или типами, 
    /// которые являются производными от содержащего класса.
    protected int ProtectedProperty { get; set; }

    /// internal - доступ ограничен текущей сборкой. 
    /// Закрыть возможность использования "на стороне"
    internal int InternalProperty { get; set; }

    /// Доступ ограничен текущей сборкой или типами,
    /// которые являются производными от содержащего класса.
    protected internal int ProtectedInternalProperty { get; set; }

    /// Доступ ограничен содержащим классом или типами,
    /// которые являются производными от содержащего класса в текущей сборке.
    private protected int PrivateProtectedProperty { get; set; }
}