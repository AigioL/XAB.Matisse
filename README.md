# XAB.Matisse
[![NuGet version (XAB.Matisse)](https://img.shields.io/nuget/v/XAB.Matisse.svg)](https://www.nuget.org/packages/XAB.Matisse/)

Matisse Binding for Xamarin Android. https://github.com/zhihu/Matisse

Commonly Used Types:
* `com.zhihu.matisse.Matisse` -> `Com.Zhihu.Matisse.Matisse`

Need to manually introduce dependencies

```
<ItemGroup>
    <!--implementation 'it.sephiroth.android.library.imagezoom:library:1.0.4'-->
    <AndroidJavaLibrary Include=".\dependencies\it.sephiroth.android.library.easing_1.0.2.jar">
      <Link>Libs\it.sephiroth.android.library.easing_1.0.2.jar</Link>
    </AndroidJavaLibrary>
    <AndroidJavaLibrary Include=".\dependencies\it.sephiroth.android.library.imagezoom_1.0.4.jar">
      <Link>Libs\it.sephiroth.android.library.imagezoom_1.0.4.jar</Link>
    </AndroidJavaLibrary>
</ItemGroup>
```

```
compileOnly 'com.github.bumptech.glide:glide:3.7.0'
compileOnly 'com.squareup.picasso:picasso:2.5.2'
```