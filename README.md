# Singleton

Supports Unity's simple Singleton Behavior.

[![](https://img.shields.io/npm/v/com.pspkurara.singleton?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.pspkurara.singleton/)
[![](https://img.shields.io/github/v/release/pspkurara/singleton)](https://github.com/pspkurara/singleton/releases/)
[![](https://img.shields.io/github/watchers/pspkurara/singleton?style=social)](https://github.com/pspkurara/external-selecion-state/subscription)

## Usage

Create a script that extends SingletonMonoBehaviour.
Specify your own class name for the generic T.
```
using UnityEngine;
using Pspkurara.Singleton;

public class SampleSingleton : SingletonMonoBehaviour<Sample>
{
	public int InspectorValue = 1;
}

public class SampleAccess : MonoBehaviour
{
	private void Start()
	{
		Debug.Log(SampleSingleton.instance.InspectorValue); // output: 1
	}
}
```

If you inherit anything with "Internal", only the inherited class has access to ".instance".
You can implement static wrapper members to make them look like constants.
```
using UnityEngine;
using Pspkurara.Singleton;

public class SampleSingleton : InternalSingletonMonoBehaviour<Sample>
{
	// raw value.
	[SerializeField]
	private int m_InspectorValue = 1;
	
	// static wrapper.
	public static int Value { get { return instance.m_InspectorValue; } }
}

public class SampleAccess : MonoBehaviour
{
	private void Start()
	{
		Debug.Log(SampleSingleton.Value); // output: 1
	}
}
```

### Full API references
* https://pspkurara.github.io/singleton/

## Installation

### Using OpenUPM
Go to Unity's project folder on the command line and call:

```
openupm add com.pspkurara.singleton
```

### Using Unity Package Manager (For Unity 2018.3 or later)
Find the manifest.json file in the Packages folder of your project and edit it to look like this:

```
{
  "dependencies": {
    "com.pspkurara.singleton": "https://github.com/pspkurara/singleton.git#upm",
    ...
  },
}
```

#### Requirement
Unity 2018.1 or later<br>
May work in Unity5, but unofficial.

## License

* [MIT](https://github.com/pspkurara/singleton/blob/master/Packages/Singleton/LICENSE.md)

## Author

* [pspkurara](https://github.com/pspkurara) 
[![](https://img.shields.io/twitter/follow/pspkurara.svg?label=Follow&style=social)](https://twitter.com/intent/follow?screen_name=pspkurara) 

## See Also

* GitHub page : https://github.com/pspkurara/singleton
