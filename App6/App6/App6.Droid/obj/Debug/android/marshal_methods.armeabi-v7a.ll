; ModuleID = 'obj/Debug/android/marshal_methods.armeabi-v7a.ll'
source_filename = "obj/Debug/android/marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


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
@assembly_image_cache_hashes = local_unnamed_addr constant [180 x i32] [
	i32 5009434, ; 0: Syncfusion.Cards.XForms.Android => 0x4c701a => 16
	i32 32687329, ; 1: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 54
	i32 34715100, ; 2: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 79
	i32 39109920, ; 3: Newtonsoft.Json.dll => 0x254c520 => 10
	i32 57263871, ; 4: Xamarin.Forms.Core.dll => 0x369c6ff => 74
	i32 101534019, ; 5: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 64
	i32 120558881, ; 6: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 64
	i32 165246403, ; 7: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 39
	i32 182336117, ; 8: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 65
	i32 209399409, ; 9: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 37
	i32 230216969, ; 10: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 49
	i32 232815796, ; 11: System.Web.Services => 0xde07cb4 => 88
	i32 278686392, ; 12: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 53
	i32 280482487, ; 13: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 47
	i32 318968648, ; 14: Xamarin.AndroidX.Activity.dll => 0x13031348 => 29
	i32 321597661, ; 15: System.Numerics => 0x132b30dd => 3
	i32 342366114, ; 16: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 51
	i32 347068432, ; 17: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0x14afd810 => 14
	i32 385762202, ; 18: System.Memory.dll => 0x16fe439a => 24
	i32 442521989, ; 19: Xamarin.Essentials => 0x1a605985 => 73
	i32 450948140, ; 20: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 46
	i32 465846621, ; 21: mscorlib => 0x1bc4415d => 9
	i32 469710990, ; 22: System.dll => 0x1bff388e => 23
	i32 476646585, ; 23: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 47
	i32 486930444, ; 24: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 58
	i32 526420162, ; 25: System.Transactions.dll => 0x1f6088c2 => 83
	i32 605376203, ; 26: System.IO.Compression.FileSystem => 0x24154ecb => 86
	i32 627609679, ; 27: Xamarin.AndroidX.CustomView => 0x2568904f => 43
	i32 663517072, ; 28: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 69
	i32 666292255, ; 29: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 34
	i32 690569205, ; 30: System.Xml.Linq.dll => 0x29293ff5 => 28
	i32 707987836, ; 31: Syncfusion.Cards.XForms.dll => 0x2a33097c => 17
	i32 719061231, ; 32: Syncfusion.Core.XForms.dll => 0x2adc00ef => 19
	i32 748832960, ; 33: SQLitePCLRaw.batteries_v2 => 0x2ca248c0 => 12
	i32 775507847, ; 34: System.IO.Compression => 0x2e394f87 => 85
	i32 809851609, ; 35: System.Drawing.Common.dll => 0x30455ad9 => 1
	i32 843511501, ; 36: Xamarin.AndroidX.Print => 0x3246f6cd => 61
	i32 928116545, ; 37: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 79
	i32 955402788, ; 38: Newtonsoft.Json => 0x38f24a24 => 10
	i32 967690846, ; 39: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 51
	i32 974778368, ; 40: FormsViewGroup.dll => 0x3a19f000 => 6
	i32 1012816738, ; 41: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 63
	i32 1035644815, ; 42: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 33
	i32 1042160112, ; 43: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 76
	i32 1052210849, ; 44: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 55
	i32 1098259244, ; 45: System => 0x41761b2c => 23
	i32 1175144683, ; 46: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 67
	i32 1204270330, ; 47: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 34
	i32 1267360935, ; 48: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 68
	i32 1292207520, ; 49: SQLitePCLRaw.core.dll => 0x4d0585a0 => 13
	i32 1293217323, ; 50: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 45
	i32 1365406463, ; 51: System.ServiceModel.Internals.dll => 0x516272ff => 80
	i32 1376866003, ; 52: Xamarin.AndroidX.SavedState => 0x52114ed3 => 63
	i32 1395857551, ; 53: Xamarin.AndroidX.Media.dll => 0x5333188f => 59
	i32 1406073936, ; 54: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 40
	i32 1411638395, ; 55: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 25
	i32 1460219004, ; 56: Xamarin.Forms.Xaml => 0x57092c7c => 77
	i32 1462112819, ; 57: System.IO.Compression.dll => 0x57261233 => 85
	i32 1469204771, ; 58: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 32
	i32 1486716862, ; 59: Syncfusion.Cards.XForms => 0x589d7fbe => 17
	i32 1516315406, ; 60: Syncfusion.Core.XForms.Android.dll => 0x5a61230e => 18
	i32 1582372066, ; 61: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 44
	i32 1592978981, ; 62: System.Runtime.Serialization.dll => 0x5ef2ee25 => 4
	i32 1622152042, ; 63: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 57
	i32 1624863272, ; 64: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 71
	i32 1636350590, ; 65: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 42
	i32 1639515021, ; 66: System.Net.Http.dll => 0x61b9038d => 2
	i32 1657153582, ; 67: System.Runtime => 0x62c6282e => 26
	i32 1658251792, ; 68: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 78
	i32 1711441057, ; 69: SQLitePCLRaw.lib.e_sqlite3.android => 0x660284a1 => 14
	i32 1729485958, ; 70: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 38
	i32 1766324549, ; 71: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 65
	i32 1776026572, ; 72: System.Core.dll => 0x69dc03cc => 22
	i32 1788241197, ; 73: Xamarin.AndroidX.Fragment => 0x6a96652d => 46
	i32 1808609942, ; 74: Xamarin.AndroidX.Loader => 0x6bcd3296 => 57
	i32 1813201214, ; 75: Xamarin.Google.Android.Material => 0x6c13413e => 78
	i32 1867746548, ; 76: Xamarin.Essentials.dll => 0x6f538cf4 => 73
	i32 1878053835, ; 77: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 77
	i32 1885316902, ; 78: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 35
	i32 1919157823, ; 79: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 60
	i32 2011961780, ; 80: System.Buffers.dll => 0x77ec19b4 => 21
	i32 2019465201, ; 81: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 55
	i32 2055257422, ; 82: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 52
	i32 2079903147, ; 83: System.Runtime.dll => 0x7bf8cdab => 26
	i32 2097448633, ; 84: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 48
	i32 2103459038, ; 85: SQLitePCLRaw.provider.e_sqlite3.dll => 0x7d603cde => 15
	i32 2126786730, ; 86: Xamarin.Forms.Platform.Android => 0x7ec430aa => 75
	i32 2201231467, ; 87: System.Net.Http => 0x8334206b => 2
	i32 2217644978, ; 88: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 67
	i32 2244775296, ; 89: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 58
	i32 2256548716, ; 90: Xamarin.AndroidX.MultiDex => 0x8680336c => 60
	i32 2261435625, ; 91: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 50
	i32 2279755925, ; 92: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 62
	i32 2315684594, ; 93: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 30
	i32 2343171156, ; 94: Syncfusion.Core.XForms => 0x8ba9f454 => 19
	i32 2354730003, ; 95: Syncfusion.Licensing => 0x8c5a5413 => 20
	i32 2465273461, ; 96: SQLitePCLRaw.batteries_v2.dll => 0x92f11675 => 12
	i32 2471841756, ; 97: netstandard.dll => 0x93554fdc => 81
	i32 2475788418, ; 98: Java.Interop.dll => 0x93918882 => 7
	i32 2501346920, ; 99: System.Data.DataSetExtensions => 0x95178668 => 84
	i32 2505896520, ; 100: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 54
	i32 2581819634, ; 101: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 68
	i32 2590531720, ; 102: App6.dll => 0x9a686088 => 5
	i32 2620871830, ; 103: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 42
	i32 2633051222, ; 104: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 53
	i32 2697630893, ; 105: App6.Droid => 0xa0ca94ad => 0
	i32 2732626843, ; 106: Xamarin.AndroidX.Activity => 0xa2e0939b => 29
	i32 2737747696, ; 107: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 32
	i32 2766581644, ; 108: Xamarin.Forms.Core => 0xa4e6af8c => 74
	i32 2778768386, ; 109: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 70
	i32 2810250172, ; 110: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 40
	i32 2819470561, ; 111: System.Xml.dll => 0xa80db4e1 => 27
	i32 2853208004, ; 112: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 70
	i32 2855708567, ; 113: Xamarin.AndroidX.Transition => 0xaa36a797 => 66
	i32 2868557005, ; 114: Syncfusion.Licensing.dll => 0xaafab4cd => 20
	i32 2874148507, ; 115: Syncfusion.Core.XForms.Android => 0xab50069b => 18
	i32 2903344695, ; 116: System.ComponentModel.Composition => 0xad0d8637 => 87
	i32 2905242038, ; 117: mscorlib.dll => 0xad2a79b6 => 9
	i32 2916838712, ; 118: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 71
	i32 2921128767, ; 119: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 31
	i32 2978675010, ; 120: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 45
	i32 3024354802, ; 121: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 49
	i32 3044182254, ; 122: FormsViewGroup => 0xb57288ee => 6
	i32 3111772706, ; 123: System.Runtime.Serialization => 0xb979e222 => 4
	i32 3204380047, ; 124: System.Data.dll => 0xbefef58f => 82
	i32 3211777861, ; 125: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 44
	i32 3247949154, ; 126: Mono.Security => 0xc197c562 => 89
	i32 3258312781, ; 127: Xamarin.AndroidX.CardView => 0xc235e84d => 38
	i32 3267021929, ; 128: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 36
	i32 3286872994, ; 129: SQLite-net.dll => 0xc3e9b3a2 => 11
	i32 3317135071, ; 130: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 43
	i32 3317144872, ; 131: System.Data => 0xc5b79d28 => 82
	i32 3340431453, ; 132: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 35
	i32 3353484488, ; 133: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 48
	i32 3353544232, ; 134: Xamarin.CommunityToolkit.dll => 0xc7e30628 => 72
	i32 3360279109, ; 135: SQLitePCLRaw.core => 0xc849ca45 => 13
	i32 3362522851, ; 136: Xamarin.AndroidX.Core => 0xc86c06e3 => 41
	i32 3366347497, ; 137: Java.Interop => 0xc8a662e9 => 7
	i32 3374999561, ; 138: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 62
	i32 3395150330, ; 139: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 25
	i32 3404865022, ; 140: System.ServiceModel.Internals => 0xcaf21dfe => 80
	i32 3407215217, ; 141: Xamarin.CommunityToolkit => 0xcb15fa71 => 72
	i32 3429136800, ; 142: System.Xml => 0xcc6479a0 => 27
	i32 3430777524, ; 143: netstandard => 0xcc7d82b4 => 81
	i32 3451943266, ; 144: App6.Droid.dll => 0xcdc07962 => 0
	i32 3476120550, ; 145: Mono.Android => 0xcf3163e6 => 8
	i32 3486566296, ; 146: System.Transactions => 0xcfd0c798 => 83
	i32 3501239056, ; 147: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 36
	i32 3509114376, ; 148: System.Xml.Linq => 0xd128d608 => 28
	i32 3536029504, ; 149: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 75
	i32 3567349600, ; 150: System.ComponentModel.Composition.dll => 0xd4a16f60 => 87
	i32 3627220390, ; 151: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 61
	i32 3632359727, ; 152: Xamarin.Forms.Platform => 0xd881692f => 76
	i32 3633644679, ; 153: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 31
	i32 3641597786, ; 154: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 52
	i32 3672681054, ; 155: Mono.Android.dll => 0xdae8aa5e => 8
	i32 3676310014, ; 156: System.Web.Services.dll => 0xdb2009fe => 88
	i32 3682565725, ; 157: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 37
	i32 3689375977, ; 158: System.Drawing.Common => 0xdbe768e9 => 1
	i32 3718780102, ; 159: Xamarin.AndroidX.Annotation => 0xdda814c6 => 30
	i32 3754567612, ; 160: SQLitePCLRaw.provider.e_sqlite3 => 0xdfca27bc => 15
	i32 3758932259, ; 161: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 50
	i32 3786282454, ; 162: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 39
	i32 3822602673, ; 163: Xamarin.AndroidX.Media => 0xe3d849b1 => 59
	i32 3829621856, ; 164: System.Numerics.dll => 0xe4436460 => 3
	i32 3876362041, ; 165: SQLite-net => 0xe70c9739 => 11
	i32 3885922214, ; 166: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 66
	i32 3896760992, ; 167: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 41
	i32 3920810846, ; 168: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 86
	i32 3921031405, ; 169: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 69
	i32 3929079551, ; 170: Syncfusion.Cards.XForms.Android.dll => 0xea30feff => 16
	i32 3945713374, ; 171: System.Data.DataSetExtensions.dll => 0xeb2ecede => 84
	i32 3955647286, ; 172: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 33
	i32 4025784931, ; 173: System.Memory => 0xeff49a63 => 24
	i32 4105002889, ; 174: Mono.Security.dll => 0xf4ad5f89 => 89
	i32 4151237749, ; 175: System.Core => 0xf76edc75 => 22
	i32 4152882818, ; 176: App6 => 0xf787f682 => 5
	i32 4182413190, ; 177: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 56
	i32 4260525087, ; 178: System.Buffers => 0xfdf2741f => 21
	i32 4292120959 ; 179: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 56
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [180 x i32] [
	i32 16, i32 54, i32 79, i32 10, i32 74, i32 64, i32 64, i32 39, ; 0..7
	i32 65, i32 37, i32 49, i32 88, i32 53, i32 47, i32 29, i32 3, ; 8..15
	i32 51, i32 14, i32 24, i32 73, i32 46, i32 9, i32 23, i32 47, ; 16..23
	i32 58, i32 83, i32 86, i32 43, i32 69, i32 34, i32 28, i32 17, ; 24..31
	i32 19, i32 12, i32 85, i32 1, i32 61, i32 79, i32 10, i32 51, ; 32..39
	i32 6, i32 63, i32 33, i32 76, i32 55, i32 23, i32 67, i32 34, ; 40..47
	i32 68, i32 13, i32 45, i32 80, i32 63, i32 59, i32 40, i32 25, ; 48..55
	i32 77, i32 85, i32 32, i32 17, i32 18, i32 44, i32 4, i32 57, ; 56..63
	i32 71, i32 42, i32 2, i32 26, i32 78, i32 14, i32 38, i32 65, ; 64..71
	i32 22, i32 46, i32 57, i32 78, i32 73, i32 77, i32 35, i32 60, ; 72..79
	i32 21, i32 55, i32 52, i32 26, i32 48, i32 15, i32 75, i32 2, ; 80..87
	i32 67, i32 58, i32 60, i32 50, i32 62, i32 30, i32 19, i32 20, ; 88..95
	i32 12, i32 81, i32 7, i32 84, i32 54, i32 68, i32 5, i32 42, ; 96..103
	i32 53, i32 0, i32 29, i32 32, i32 74, i32 70, i32 40, i32 27, ; 104..111
	i32 70, i32 66, i32 20, i32 18, i32 87, i32 9, i32 71, i32 31, ; 112..119
	i32 45, i32 49, i32 6, i32 4, i32 82, i32 44, i32 89, i32 38, ; 120..127
	i32 36, i32 11, i32 43, i32 82, i32 35, i32 48, i32 72, i32 13, ; 128..135
	i32 41, i32 7, i32 62, i32 25, i32 80, i32 72, i32 27, i32 81, ; 136..143
	i32 0, i32 8, i32 83, i32 36, i32 28, i32 75, i32 87, i32 61, ; 144..151
	i32 76, i32 31, i32 52, i32 8, i32 88, i32 37, i32 1, i32 30, ; 152..159
	i32 15, i32 50, i32 39, i32 59, i32 3, i32 11, i32 66, i32 41, ; 160..167
	i32 86, i32 69, i32 16, i32 84, i32 33, i32 24, i32 89, i32 22, ; 168..175
	i32 5, i32 56, i32 21, i32 56 ; 176..179
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
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


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
