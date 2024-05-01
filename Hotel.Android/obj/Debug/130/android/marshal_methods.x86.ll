; ModuleID = 'obj\Debug\130\android\marshal_methods.x86.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [244 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 64
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 98
	i32 39852199, ; 2: Plugin.Permissions => 0x26018a7 => 12
	i32 57263871, ; 3: Xamarin.Forms.Core.dll => 0x369c6ff => 91
	i32 101534019, ; 4: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 80
	i32 120558881, ; 5: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 80
	i32 134690465, ; 6: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x80736a1 => 106
	i32 159306688, ; 7: System.ComponentModel.Annotations => 0x97ed3c0 => 1
	i32 165246403, ; 8: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 41
	i32 166922606, ; 9: Xamarin.Android.Support.Compat.dll => 0x9f3096e => 29
	i32 182336117, ; 10: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 82
	i32 209399409, ; 11: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 39
	i32 212497893, ; 12: Xamarin.Forms.Maps.Android => 0xcaa75e5 => 92
	i32 230216969, ; 13: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 58
	i32 232815796, ; 14: System.Web.Services => 0xde07cb4 => 120
	i32 261689757, ; 15: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 44
	i32 278686392, ; 16: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 62
	i32 280482487, ; 17: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 56
	i32 318968648, ; 18: Xamarin.AndroidX.Activity.dll => 0x13031348 => 31
	i32 319314094, ; 19: Xamarin.Forms.Maps => 0x130858ae => 93
	i32 321597661, ; 20: System.Numerics => 0x132b30dd => 22
	i32 342366114, ; 21: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 60
	i32 347068432, ; 22: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0x14afd810 => 16
	i32 385762202, ; 23: System.Memory.dll => 0x16fe439a => 21
	i32 441335492, ; 24: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 43
	i32 442521989, ; 25: Xamarin.Essentials => 0x1a605985 => 90
	i32 450948140, ; 26: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 55
	i32 465846621, ; 27: mscorlib => 0x1bc4415d => 8
	i32 469710990, ; 28: System.dll => 0x1bff388e => 20
	i32 476646585, ; 29: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 56
	i32 486930444, ; 30: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 68
	i32 514659665, ; 31: Xamarin.Android.Support.Compat => 0x1ead1551 => 29
	i32 526420162, ; 32: System.Transactions.dll => 0x1f6088c2 => 114
	i32 527452488, ; 33: Xamarin.Kotlin.StdLib.Jdk7 => 0x1f704948 => 106
	i32 605376203, ; 34: System.IO.Compression.FileSystem => 0x24154ecb => 118
	i32 627609679, ; 35: Xamarin.AndroidX.CustomView => 0x2568904f => 49
	i32 639843206, ; 36: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x26233b86 => 54
	i32 640451271, ; 37: Hotel.dll => 0x262c82c7 => 5
	i32 663517072, ; 38: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 87
	i32 666292255, ; 39: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 36
	i32 690569205, ; 40: System.Xml.Linq.dll => 0x29293ff5 => 27
	i32 691348768, ; 41: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 108
	i32 692692150, ; 42: Xamarin.Android.Support.Annotations => 0x2949a4b6 => 28
	i32 700284507, ; 43: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 103
	i32 720511267, ; 44: Xamarin.Kotlin.StdLib.Jdk8 => 0x2af22123 => 107
	i32 748832960, ; 45: SQLitePCLRaw.batteries_v2 => 0x2ca248c0 => 14
	i32 775507847, ; 46: System.IO.Compression => 0x2e394f87 => 117
	i32 809851609, ; 47: System.Drawing.Common.dll => 0x30455ad9 => 116
	i32 835661280, ; 48: MvvmHelpers.dll => 0x31cf2de0 => 9
	i32 843511501, ; 49: Xamarin.AndroidX.Print => 0x3246f6cd => 75
	i32 928116545, ; 50: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 98
	i32 956575887, ; 51: Xamarin.Kotlin.StdLib.Jdk8.dll => 0x3904308f => 107
	i32 957807352, ; 52: Plugin.CurrentActivity => 0x3916faf8 => 10
	i32 967690846, ; 53: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 60
	i32 974778368, ; 54: FormsViewGroup.dll => 0x3a19f000 => 4
	i32 1012816738, ; 55: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 79
	i32 1035644815, ; 56: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 35
	i32 1042160112, ; 57: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 95
	i32 1052210849, ; 58: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 65
	i32 1084122840, ; 59: Xamarin.Kotlin.StdLib => 0x409e66d8 => 105
	i32 1098259244, ; 60: System => 0x41761b2c => 20
	i32 1137654822, ; 61: Plugin.Permissions.dll => 0x43cf3c26 => 12
	i32 1175144683, ; 62: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 85
	i32 1178241025, ; 63: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 72
	i32 1204270330, ; 64: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 36
	i32 1264511973, ; 65: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0x4b5eebe5 => 81
	i32 1267360935, ; 66: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 86
	i32 1275534314, ; 67: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 108
	i32 1282958517, ; 68: Plugin.Geolocator => 0x4c7864b5 => 11
	i32 1292207520, ; 69: SQLitePCLRaw.core.dll => 0x4d0585a0 => 15
	i32 1293217323, ; 70: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 51
	i32 1365406463, ; 71: System.ServiceModel.Internals.dll => 0x516272ff => 111
	i32 1376866003, ; 72: Xamarin.AndroidX.SavedState => 0x52114ed3 => 79
	i32 1395857551, ; 73: Xamarin.AndroidX.Media.dll => 0x5333188f => 69
	i32 1406073936, ; 74: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 45
	i32 1411638395, ; 75: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 24
	i32 1460219004, ; 76: Xamarin.Forms.Xaml => 0x57092c7c => 96
	i32 1462112819, ; 77: System.IO.Compression.dll => 0x57261233 => 117
	i32 1469204771, ; 78: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 34
	i32 1530663695, ; 79: Xamarin.Forms.Maps.dll => 0x5b3c130f => 93
	i32 1574652163, ; 80: Xamarin.Android.Support.Core.Utils.dll => 0x5ddb4903 => 30
	i32 1582372066, ; 81: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 50
	i32 1592978981, ; 82: System.Runtime.Serialization.dll => 0x5ef2ee25 => 3
	i32 1622152042, ; 83: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 67
	i32 1624863272, ; 84: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 89
	i32 1635184631, ; 85: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x6176eff7 => 54
	i32 1636350590, ; 86: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 48
	i32 1639515021, ; 87: System.Net.Http.dll => 0x61b9038d => 2
	i32 1657153582, ; 88: System.Runtime => 0x62c6282e => 25
	i32 1658241508, ; 89: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 83
	i32 1658251792, ; 90: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 97
	i32 1670060433, ; 91: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 44
	i32 1698840827, ; 92: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 104
	i32 1711441057, ; 93: SQLitePCLRaw.lib.e_sqlite3.android => 0x660284a1 => 16
	i32 1729485958, ; 94: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 40
	i32 1766324549, ; 95: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 82
	i32 1776026572, ; 96: System.Core.dll => 0x69dc03cc => 19
	i32 1788241197, ; 97: Xamarin.AndroidX.Fragment => 0x6a96652d => 55
	i32 1808609942, ; 98: Xamarin.AndroidX.Loader => 0x6bcd3296 => 67
	i32 1813058853, ; 99: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 105
	i32 1813201214, ; 100: Xamarin.Google.Android.Material => 0x6c13413e => 97
	i32 1818569960, ; 101: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 73
	i32 1867746548, ; 102: Xamarin.Essentials.dll => 0x6f538cf4 => 90
	i32 1878053835, ; 103: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 96
	i32 1881862856, ; 104: Xamarin.Forms.Maps.Android.dll => 0x702af2c8 => 92
	i32 1885316902, ; 105: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 37
	i32 1908813208, ; 106: Xamarin.GooglePlayServices.Basement => 0x71c62d98 => 100
	i32 1919157823, ; 107: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 70
	i32 1981405787, ; 108: Hotel.Android.dll => 0x7619da5b => 0
	i32 1983156543, ; 109: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 104
	i32 2011961780, ; 110: System.Buffers.dll => 0x77ec19b4 => 18
	i32 2019465201, ; 111: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 65
	i32 2055257422, ; 112: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 61
	i32 2079903147, ; 113: System.Runtime.dll => 0x7bf8cdab => 25
	i32 2090596640, ; 114: System.Numerics.Vectors => 0x7c9bf920 => 23
	i32 2097448633, ; 115: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 57
	i32 2103459038, ; 116: SQLitePCLRaw.provider.e_sqlite3.dll => 0x7d603cde => 17
	i32 2126786730, ; 117: Xamarin.Forms.Platform.Android => 0x7ec430aa => 94
	i32 2129483829, ; 118: Xamarin.GooglePlayServices.Base.dll => 0x7eed5835 => 99
	i32 2166116741, ; 119: Xamarin.Android.Support.Core.Utils => 0x811c5185 => 30
	i32 2201107256, ; 120: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 109
	i32 2201231467, ; 121: System.Net.Http => 0x8334206b => 2
	i32 2217644978, ; 122: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 85
	i32 2244775296, ; 123: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 68
	i32 2256548716, ; 124: Xamarin.AndroidX.MultiDex => 0x8680336c => 70
	i32 2261435625, ; 125: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 59
	i32 2279755925, ; 126: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 77
	i32 2315684594, ; 127: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 32
	i32 2403452196, ; 128: Xamarin.AndroidX.Emoji2.dll => 0x8f41c524 => 53
	i32 2409053734, ; 129: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 74
	i32 2435904999, ; 130: System.ComponentModel.DataAnnotations.dll => 0x9130f5e7 => 110
	i32 2465273461, ; 131: SQLitePCLRaw.batteries_v2.dll => 0x92f11675 => 14
	i32 2465532216, ; 132: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 43
	i32 2471841756, ; 133: netstandard.dll => 0x93554fdc => 112
	i32 2475788418, ; 134: Java.Interop.dll => 0x93918882 => 6
	i32 2501346920, ; 135: System.Data.DataSetExtensions => 0x95178668 => 115
	i32 2505896520, ; 136: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 64
	i32 2581819634, ; 137: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 86
	i32 2605712449, ; 138: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 109
	i32 2620871830, ; 139: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 48
	i32 2624644809, ; 140: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 52
	i32 2633051222, ; 141: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 62
	i32 2701096212, ; 142: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 83
	i32 2732626843, ; 143: Xamarin.AndroidX.Activity => 0xa2e0939b => 31
	i32 2737747696, ; 144: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 34
	i32 2766581644, ; 145: Xamarin.Forms.Core => 0xa4e6af8c => 91
	i32 2770495804, ; 146: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 103
	i32 2778768386, ; 147: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 88
	i32 2779977773, ; 148: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0xa5b3182d => 78
	i32 2806986428, ; 149: Plugin.CurrentActivity.dll => 0xa74f36bc => 10
	i32 2810250172, ; 150: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 45
	i32 2819470561, ; 151: System.Xml.dll => 0xa80db4e1 => 26
	i32 2821294376, ; 152: Xamarin.AndroidX.ResourceInspection.Annotation => 0xa8298928 => 78
	i32 2847418871, ; 153: Xamarin.GooglePlayServices.Base => 0xa9b829f7 => 99
	i32 2853208004, ; 154: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 88
	i32 2855708567, ; 155: Xamarin.AndroidX.Transition => 0xaa36a797 => 84
	i32 2903344695, ; 156: System.ComponentModel.Composition => 0xad0d8637 => 119
	i32 2905242038, ; 157: mscorlib.dll => 0xad2a79b6 => 8
	i32 2916838712, ; 158: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 89
	i32 2919462931, ; 159: System.Numerics.Vectors.dll => 0xae037813 => 23
	i32 2921128767, ; 160: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 33
	i32 2978675010, ; 161: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 51
	i32 2996846495, ; 162: Xamarin.AndroidX.Lifecycle.Process.dll => 0xb2a03f9f => 63
	i32 3016983068, ; 163: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 81
	i32 3017076677, ; 164: Xamarin.GooglePlayServices.Maps => 0xb3d4efc5 => 101
	i32 3024354802, ; 165: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 58
	i32 3044182254, ; 166: FormsViewGroup => 0xb57288ee => 4
	i32 3057625584, ; 167: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 71
	i32 3058099980, ; 168: Xamarin.GooglePlayServices.Tasks => 0xb646e70c => 102
	i32 3111772706, ; 169: System.Runtime.Serialization => 0xb979e222 => 3
	i32 3126016514, ; 170: Plugin.Geolocator.dll => 0xba533a02 => 11
	i32 3204380047, ; 171: System.Data.dll => 0xbefef58f => 113
	i32 3211777861, ; 172: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 50
	i32 3230466174, ; 173: Xamarin.GooglePlayServices.Basement.dll => 0xc08d007e => 100
	i32 3247949154, ; 174: Mono.Security => 0xc197c562 => 121
	i32 3257332390, ; 175: MvvmHelpers => 0xc226f2a6 => 9
	i32 3258312781, ; 176: Xamarin.AndroidX.CardView => 0xc235e84d => 40
	i32 3267021929, ; 177: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 38
	i32 3280506390, ; 178: System.ComponentModel.Annotations.dll => 0xc3888e16 => 1
	i32 3286872994, ; 179: SQLite-net.dll => 0xc3e9b3a2 => 13
	i32 3317135071, ; 180: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 49
	i32 3317144872, ; 181: System.Data => 0xc5b79d28 => 113
	i32 3340431453, ; 182: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 37
	i32 3345895724, ; 183: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xc76e512c => 76
	i32 3346324047, ; 184: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 72
	i32 3353484488, ; 185: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 57
	i32 3360279109, ; 186: SQLitePCLRaw.core => 0xc849ca45 => 15
	i32 3362522851, ; 187: Xamarin.AndroidX.Core => 0xc86c06e3 => 47
	i32 3366347497, ; 188: Java.Interop => 0xc8a662e9 => 6
	i32 3374999561, ; 189: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 77
	i32 3395150330, ; 190: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 24
	i32 3404865022, ; 191: System.ServiceModel.Internals => 0xcaf21dfe => 111
	i32 3429136800, ; 192: System.Xml => 0xcc6479a0 => 26
	i32 3430777524, ; 193: netstandard => 0xcc7d82b4 => 112
	i32 3439690031, ; 194: Xamarin.Android.Support.Annotations.dll => 0xcd05812f => 28
	i32 3441283291, ; 195: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 52
	i32 3476120550, ; 196: Mono.Android => 0xcf3163e6 => 7
	i32 3486566296, ; 197: System.Transactions => 0xcfd0c798 => 114
	i32 3493954962, ; 198: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 42
	i32 3501239056, ; 199: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 38
	i32 3509114376, ; 200: System.Xml.Linq => 0xd128d608 => 27
	i32 3536029504, ; 201: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 94
	i32 3567349600, ; 202: System.ComponentModel.Composition.dll => 0xd4a16f60 => 119
	i32 3618140916, ; 203: Xamarin.AndroidX.Preference => 0xd7a872f4 => 74
	i32 3627220390, ; 204: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 75
	i32 3632359727, ; 205: Xamarin.Forms.Platform => 0xd881692f => 95
	i32 3633644679, ; 206: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 33
	i32 3641597786, ; 207: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 61
	i32 3645089577, ; 208: System.ComponentModel.DataAnnotations => 0xd943a729 => 110
	i32 3672681054, ; 209: Mono.Android.dll => 0xdae8aa5e => 7
	i32 3676310014, ; 210: System.Web.Services.dll => 0xdb2009fe => 120
	i32 3682565725, ; 211: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 39
	i32 3684561358, ; 212: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 42
	i32 3689375977, ; 213: System.Drawing.Common => 0xdbe768e9 => 116
	i32 3706696989, ; 214: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 46
	i32 3718780102, ; 215: Xamarin.AndroidX.Annotation => 0xdda814c6 => 32
	i32 3724971120, ; 216: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 71
	i32 3754567612, ; 217: SQLitePCLRaw.provider.e_sqlite3 => 0xdfca27bc => 17
	i32 3758932259, ; 218: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 59
	i32 3786282454, ; 219: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 41
	i32 3822602673, ; 220: Xamarin.AndroidX.Media => 0xe3d849b1 => 69
	i32 3829621856, ; 221: System.Numerics.dll => 0xe4436460 => 22
	i32 3862004275, ; 222: Hotel.Android => 0xe6318233 => 0
	i32 3876362041, ; 223: SQLite-net => 0xe70c9739 => 13
	i32 3885922214, ; 224: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 84
	i32 3888767677, ; 225: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0xe7c9e2bd => 76
	i32 3896760992, ; 226: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 47
	i32 3920810846, ; 227: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 118
	i32 3921031405, ; 228: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 87
	i32 3931092270, ; 229: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 73
	i32 3945713374, ; 230: System.Data.DataSetExtensions.dll => 0xeb2ecede => 115
	i32 3955647286, ; 231: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 35
	i32 3959773229, ; 232: Xamarin.AndroidX.Lifecycle.Process => 0xec05582d => 63
	i32 3970018735, ; 233: Xamarin.GooglePlayServices.Tasks.dll => 0xeca1adaf => 102
	i32 4025784931, ; 234: System.Memory => 0xeff49a63 => 21
	i32 4101593132, ; 235: Xamarin.AndroidX.Emoji2 => 0xf479582c => 53
	i32 4105002889, ; 236: Mono.Security.dll => 0xf4ad5f89 => 121
	i32 4151237749, ; 237: System.Core => 0xf76edc75 => 19
	i32 4182413190, ; 238: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 66
	i32 4194743977, ; 239: Hotel => 0xfa06b6a9 => 5
	i32 4256097574, ; 240: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 46
	i32 4260525087, ; 241: System.Buffers => 0xfdf2741f => 18
	i32 4278134329, ; 242: Xamarin.GooglePlayServices.Maps.dll => 0xfeff2639 => 101
	i32 4292120959 ; 243: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 66
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [244 x i32] [
	i32 64, i32 98, i32 12, i32 91, i32 80, i32 80, i32 106, i32 1, ; 0..7
	i32 41, i32 29, i32 82, i32 39, i32 92, i32 58, i32 120, i32 44, ; 8..15
	i32 62, i32 56, i32 31, i32 93, i32 22, i32 60, i32 16, i32 21, ; 16..23
	i32 43, i32 90, i32 55, i32 8, i32 20, i32 56, i32 68, i32 29, ; 24..31
	i32 114, i32 106, i32 118, i32 49, i32 54, i32 5, i32 87, i32 36, ; 32..39
	i32 27, i32 108, i32 28, i32 103, i32 107, i32 14, i32 117, i32 116, ; 40..47
	i32 9, i32 75, i32 98, i32 107, i32 10, i32 60, i32 4, i32 79, ; 48..55
	i32 35, i32 95, i32 65, i32 105, i32 20, i32 12, i32 85, i32 72, ; 56..63
	i32 36, i32 81, i32 86, i32 108, i32 11, i32 15, i32 51, i32 111, ; 64..71
	i32 79, i32 69, i32 45, i32 24, i32 96, i32 117, i32 34, i32 93, ; 72..79
	i32 30, i32 50, i32 3, i32 67, i32 89, i32 54, i32 48, i32 2, ; 80..87
	i32 25, i32 83, i32 97, i32 44, i32 104, i32 16, i32 40, i32 82, ; 88..95
	i32 19, i32 55, i32 67, i32 105, i32 97, i32 73, i32 90, i32 96, ; 96..103
	i32 92, i32 37, i32 100, i32 70, i32 0, i32 104, i32 18, i32 65, ; 104..111
	i32 61, i32 25, i32 23, i32 57, i32 17, i32 94, i32 99, i32 30, ; 112..119
	i32 109, i32 2, i32 85, i32 68, i32 70, i32 59, i32 77, i32 32, ; 120..127
	i32 53, i32 74, i32 110, i32 14, i32 43, i32 112, i32 6, i32 115, ; 128..135
	i32 64, i32 86, i32 109, i32 48, i32 52, i32 62, i32 83, i32 31, ; 136..143
	i32 34, i32 91, i32 103, i32 88, i32 78, i32 10, i32 45, i32 26, ; 144..151
	i32 78, i32 99, i32 88, i32 84, i32 119, i32 8, i32 89, i32 23, ; 152..159
	i32 33, i32 51, i32 63, i32 81, i32 101, i32 58, i32 4, i32 71, ; 160..167
	i32 102, i32 3, i32 11, i32 113, i32 50, i32 100, i32 121, i32 9, ; 168..175
	i32 40, i32 38, i32 1, i32 13, i32 49, i32 113, i32 37, i32 76, ; 176..183
	i32 72, i32 57, i32 15, i32 47, i32 6, i32 77, i32 24, i32 111, ; 184..191
	i32 26, i32 112, i32 28, i32 52, i32 7, i32 114, i32 42, i32 38, ; 192..199
	i32 27, i32 94, i32 119, i32 74, i32 75, i32 95, i32 33, i32 61, ; 200..207
	i32 110, i32 7, i32 120, i32 39, i32 42, i32 116, i32 46, i32 32, ; 208..215
	i32 71, i32 17, i32 59, i32 41, i32 69, i32 22, i32 0, i32 13, ; 216..223
	i32 84, i32 76, i32 47, i32 118, i32 87, i32 73, i32 115, i32 35, ; 224..231
	i32 63, i32 102, i32 21, i32 53, i32 121, i32 19, i32 66, i32 5, ; 232..239
	i32 46, i32 18, i32 101, i32 66 ; 240..243
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
