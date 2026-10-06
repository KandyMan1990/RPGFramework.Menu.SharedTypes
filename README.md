# RPGFramework.Menu.SharedTypes

What other modules need to open the menus, without depending on the Menu package itself.

Requires Unity 6000.6 or newer and RPGFramework.Core.SharedTypes.

- **`IMenuModule`**: the menu module, which keeps a stack of open menus. `PushMenu` opens one over the current one,
  `PopMenu` closes it, and `IsMenuInStack<T>` says whether one is open. A menu that wants to leave for another module
  calls `RequestModuleChange` rather than asking Core directly, so the menu module can finish bringing the menus back up
  before it goes.
- **`MenuConstants.MODULE_ID`**: its module id, 1.
- **`MenuType`**: which menu to open: `Begin`, `Config`, `Language`, `Party`, `Save` and `Load` are built; `Inventory`,
  `Abilities` and `CharacterInfo` are reserved and not yet built.
- **`MenuArgs`** and **`IMenuArgsStore`**: the menu to open on entering the menu module, set by whatever opens it. Your
  global installer binds the store to the Menu package's `MenuArgsStore`.

```csharp
menuArgsStore.Set(new MenuArgs((byte)MenuType.Party));
```
