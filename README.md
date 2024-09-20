![Banner](https://github.com/user-attachments/assets/82e8b17d-b717-414a-b774-146f249932f2)

# Overview
A custom `Unity` property drawer designed to optimize the inspector view for `Vector4` fields.
It reduces the space taken by the default layout, offering a cleaner, more compact design without sacrificing
functionality.

## Features
- **[Compact Layout](#Showcase):** Displays `Vector4` fields in a condensed format, optimizing space in the inspector
- **[Prefab Support](#Working-With-Prefabs):** Correctly handles prefab instances and variants, ensuring changes are
  tracked and displayed properly with the ability to apply/revert changes
- **No Configuration Required:** Automatically applies to all `Vector4` fields without requiring any additional
  setup or custom inspectors/attributes
- **[Inspector Modes Handling](#Inspector-Modes):** Adapts seamlessly to both wide and compact inspector modes,  
  ensuring a consistent experience
- **Custom Inspectors Support:** Fully compatible with custom inspectors, allowing effortless integration into
  existing editor workflows

## Installation
You can install the `Vector4 Compact Drawer` package using one of the following methods:

### 1. Unity Package Manager

1. Open `Unity`, then go to `Window -> Package Manager`.
2. Click on the dropdown and select `Add package from git URL...`
3. Paste the following `URL` and click `Add`:
```
https://github.com/danliukuri/Vector4CompactDrawer.git?path=Vector4CompactDrawer.Unity/Assets/Plugins/Vector4CompactDrawer
```

### 2. Download From Releases

1. Go to the [Releases Page](https://github.com/danliukuri/Vector4CompactDrawer/releases).
2. Download the desired package(s):
    - Core package: `Vector4CompactDrawer@vX.X.X.unitypackage`
    - Samples (optional): `Vector4CompactDrawer.Samples@vX.X.X.unitypackage`
3. Import the package(s) into your `Unity` project.

## Usage
Once installed, the `Vector4 Compact Drawer `will automatically apply to all `Vector4` fields in your scripts.
No additional configuration is required.

See the [Showcase sample](#showcase) for simple usage demonstration.

## Samples
To demonstrate the capabilities of the `Vector4 Compact Drawer`, following samples have been created.

### Showcase
To see the compact drawer in action, simple `Vector4` serialized field exposing script was created:

```csharp
public class Vector4Exposer : MonoBehaviour
{
    [SerializeField] private Vector4 serializedVector;
}
```
When you select a `GameObject` with this component,
the `Vector4` field will be displayed in a compact layout in the `Unity Inspector`.

#### Working With Prefabs
The drawer fully supports prefab instances and variants, ensuring changes are tracked and displayed correctly.

![PrefabEditing](https://github.com/user-attachments/assets/5bb842f6-159b-4a0c-a2cb-3cb74fabc398)

#### Inspector Modes

The drawer automatically adjusts based on the inspector's width
([`EditorGUIUtility.wideMode`](https://docs.unity3d.com/ScriptReference/EditorGUIUtility-wideMode)),
ensuring a consistent user experience across different layouts:

- **Wide Mode**: The drawer displays the `Vector4` field in a single-line layout:
  ![WideMode](https://github.com/user-attachments/assets/c4258505-015b-4559-b204-d58286cac25d)

- **Compact Mode**: The field is split across two lines to maintain readability while conserving space:
  ![CompactMode](https://github.com/user-attachments/assets/02403ab9-4364-4db1-a02a-f99775d53c03)

## Contribution
Feel free to submit issues or pull requests to improve this package.