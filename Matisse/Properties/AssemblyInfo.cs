using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Android.App;

[assembly: SuppressIldasm]

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Matisse")]
[assembly: AssemblyDescription("https://bintray.com/zhihu/maven/matisse/0.5.1")]
//[assembly: AssemblyConfiguration("")]
//[assembly: AssemblyCompany("")]
//[assembly: AssemblyProduct("Matisse")]
//[assembly: AssemblyCopyright("Copyright ©  2018")]
//[assembly: AssemblyTrademark("")]
//[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("0.5.1")]
[assembly: AssemblyFileVersion("0.5.1")]

// https://bintray.com/zhihu/maven/matisse/0.5.1
// https://github.com/zhihu/Matisse/tree/v0.5.1
// https://github.com/zhihu/Matisse/blob/v0.5.1/matisse/build.gradle

//android {
//    compileSdkVersion 27
//    buildToolsVersion '27.0.3'

//    defaultConfig {
//        minSdkVersion 14
//        targetSdkVersion 27
//    }
//    compileOptions {
//        sourceCompatibility JavaVersion.VERSION_1_7
//        targetCompatibility JavaVersion.VERSION_1_7
//    }
//    lintOptions {
//        abortOnError false
//    }
//}

//ext.supportLibVersion = '27.1.1'

//dependencies {
//    implementation fileTree(dir: 'libs', include: ['*.jar'])

//    implementation "com.android.support:support-v4:${supportLibVersion}"
//    implementation "com.android.support:appcompat-v7:${supportLibVersion}"
//    implementation "com.android.support:support-annotations:${supportLibVersion}"
//    implementation "com.android.support:recyclerview-v7:${supportLibVersion}"
//    implementation 'it.sephiroth.android.library.imagezoom:library:1.0.4'

//    compileOnly 'com.github.bumptech.glide:glide:3.7.0'
//    compileOnly 'com.squareup.picasso:picasso:2.5.2'
//}

// com.zhihu.matisse.engine.impl.GlideEngine dependencie com.github.bumptech.glide
// com.zhihu.matisse.engine.impl.PicassoEngine dependencie com.squareup.picasso:picasso

// ---- it.sephiroth.android.library.imagezoom https://github.com/sephiroth74/ImageViewZoom ----

// Download https://jcenter.bintray.com/it/sephiroth/android/library/imagezoom/library/1.0.4/library-1.0.4.aar
// Download https://jcenter.bintray.com/it/sephiroth/android/library/easing/library/1.0.2/library-1.0.2.aar

//<ItemGroup>
//    <AndroidJavaLibrary Include=".\dependencies\it.sephiroth.android.library.easing_1.0.2.jar">
//      <Link>Libs\it.sephiroth.android.library.easing_1.0.2.jar</Link>
//    </AndroidJavaLibrary>
//    <AndroidJavaLibrary Include=".\dependencies\it.sephiroth.android.library.imagezoom_1.0.4.jar">
//      <Link>Libs\it.sephiroth.android.library.imagezoom_1.0.4.jar</Link>
//    </AndroidJavaLibrary>
//</ItemGroup>
