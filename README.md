# large-scale project for testing UnrealSharp hot reload functionality. (500 Copies)
| Description | Commit    | Time (Seconds) |
| ----------- | --------- | ------- |
| Original Build | f20377477944cfe2473126fdf3c3d00f9ae43d7c  | 41.06 - 45.21 |
| 520 PR | 9ef01274d770ff18d585f827306e985eb877eb9b  | 32.73 - 34.29 |
| Proof of concept | Not committed yet | 8.03 - 9.16 |

<hr>

| Files | Description |
| ----------- | ----------- |
| BasicActor.cs | A simple class with 10000 BP Sub-Class |
| AdvancedActor.cs | A more Advanced class with 10000 BP Sub-Class |
| \Copies\\* | Copies of AdvancedActor with properies and class names incremented |

<hr>

| Utilities Files | Description |
| ----------- | ----------- |
| index.php | simple script for creating the C# Copies |
| /Content/CreateBasicActors.py | Simple python script for creating copies of BP |

# Proof of concept status

| Weaver Functionality | State |
| --------- | -------- |
| Enums | Partial |
| Interfaces | Partial |
| Structs | Partial |
| Classes | Partial |
| Delegates | ✅ |
| MetaData | Partial |


