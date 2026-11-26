# Project Coding Guidelines

When changing this project, use straightforward, conventional C# that is easy for a beginner to read and maintain.

- Prefer clear, descriptive names and explicit types when they make the code easier to understand.
- Use ordinary `if`/`else`, `switch`, `foreach`, and `try`/`catch` statements with braces.
- Keep SQL parameter code beginner-friendly. Follow the simple parameter style already used nearby (such as `Parameters.AddWithValue`) instead of introducing explicit `SqlDbType` syntax when it is not needed. Keep all SQL queries parameterized.
- Keep methods small and focused, and explain non-obvious logic with brief comments.
- Prefer simple classes and direct control flow. Avoid advanced language features, clever one-liners, dense expressions, unnecessary abstractions, and shortcut-heavy code.
- Avoid LINQ, `var`, expression-bodied members, null-conditional/coalescing operators, pattern matching, lambdas, and other shorthand when a basic statement is clearer. Use them only when they are already established in nearby code and materially improve readability.
- Follow the existing WinForms and project structure. Do not rewrite generated `.Designer.cs` files by hand unless specifically necessary.
- The user wants WinForms design changes made through Visual Studio's visual Designer and Properties window. Codex may add or modify controls and their visual properties through that UI, but must not create the design by writing or editing `.Designer.cs` code or adding UI setup/initialization code to `.cs` files. Use code-behind only for application behavior, including runtime state changes such as enabling fields after an Edit click. If the visual Designer is unavailable, explain that limitation and provide the user with the control names and Properties settings to apply there instead of coding the design.
- Make the smallest clear change that solves the requested problem, and preserve existing behavior outside that change.
