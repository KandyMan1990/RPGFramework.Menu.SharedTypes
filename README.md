# RPGFramework.Menu.SharedTypes

What other modules need to open the menus, without depending on the Menu package itself.

Requires Unity 6000.6 or newer, RPGFramework.Core.SharedTypes and RPGFramework.Hashing.

- **`IMenuModule`**: the menu module, which keeps a stack of open menus. `PushMenu` opens one over the current one, by
  its id, and `PopMenu` closes it. A menu that wants to leave for another module calls `RequestModuleChange` with one of
  `MenuOutcomes` rather than asking Core directly, so the menu module can finish bringing the menus back up before it
  goes.
- **`MenuConstants.MODULE_ID`**: its module id, 1.
- **`MenuOutcomes`**: what the menu tells Core as its last menu closes, for the game's module router: `CLOSED`, back
  to what it opened over, or `PLAYTHROUGH`, a game begun or loaded.
- **`MenuIds`**: the framework's menus, each the hash of its name — `Begin`, `Config`, `Language`, `Controls`,
  `Party`, `Save` and `Load` — with the names themselves, `MenuIds.PARTY` and so on. A game's own menu is named the same
  way, by its name's hash, and added to the Menu package's menu database.
- **`MenuArgs`** and **`IMenuArgsStore`**: the menu to open on entering the menu module, set by whatever opens it. Your
  global installer binds the store to the Menu package's `MenuArgsStore`.

```csharp
menuArgsStore.Set(new MenuArgs(MenuIds.Party));
```
