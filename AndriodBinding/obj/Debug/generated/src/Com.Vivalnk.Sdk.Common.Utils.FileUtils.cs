using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/FileUtils", DoNotGenerateAcw=true)]
	public partial class FileUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/field[@name='FILE_EXTENSION_SEPARATOR']"
		[Register ("FILE_EXTENSION_SEPARATOR")]
		public const string FileExtensionSeparator = (string) ".";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/FileUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileUtils); }
		}

		protected FileUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDiskAvailableSize;
		public static unsafe long DiskAvailableSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='getDiskAvailableSize' and count(parameter)=0]"
			[Register ("getDiskAvailableSize", "()J", "")]
			get {
				if (id_getDiskAvailableSize == IntPtr.Zero)
					id_getDiskAvailableSize = JNIEnv.GetStaticMethodID (class_ref, "getDiskAvailableSize", "()J");
				try {
					return JNIEnv.CallStaticLongMethod  (class_ref, id_getDiskAvailableSize);
				} finally {
				}
			}
		}

		static IntPtr id_isDiskSpaceAvailable;
		public static unsafe bool IsDiskSpaceAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='isDiskSpaceAvailable' and count(parameter)=0]"
			[Register ("isDiskSpaceAvailable", "()Z", "")]
			get {
				if (id_isDiskSpaceAvailable == IntPtr.Zero)
					id_isDiskSpaceAvailable = JNIEnv.GetStaticMethodID (class_ref, "isDiskSpaceAvailable", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isDiskSpaceAvailable);
				} finally {
				}
			}
		}

		static IntPtr id_isExternalStorageReadable;
		public static unsafe bool IsExternalStorageReadable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='isExternalStorageReadable' and count(parameter)=0]"
			[Register ("isExternalStorageReadable", "()Z", "")]
			get {
				if (id_isExternalStorageReadable == IntPtr.Zero)
					id_isExternalStorageReadable = JNIEnv.GetStaticMethodID (class_ref, "isExternalStorageReadable", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isExternalStorageReadable);
				} finally {
				}
			}
		}

		static IntPtr id_isExternalStorageWritable;
		public static unsafe bool IsExternalStorageWritable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='isExternalStorageWritable' and count(parameter)=0]"
			[Register ("isExternalStorageWritable", "()Z", "")]
			get {
				if (id_isExternalStorageWritable == IntPtr.Zero)
					id_isExternalStorageWritable = JNIEnv.GetStaticMethodID (class_ref, "isExternalStorageWritable", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isExternalStorageWritable);
				} finally {
				}
			}
		}

		static IntPtr id_isSDCardAvailable;
		public static unsafe bool IsSDCardAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='isSDCardAvailable' and count(parameter)=0]"
			[Register ("isSDCardAvailable", "()Z", "")]
			get {
				if (id_isSDCardAvailable == IntPtr.Zero)
					id_isSDCardAvailable = JNIEnv.GetStaticMethodID (class_ref, "isSDCardAvailable", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSDCardAvailable);
				} finally {
				}
			}
		}

		static IntPtr id_copy_Ljava_io_InputStream_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.lang.String']]"
		[Register ("copy", "(Ljava/io/InputStream;Ljava/lang/String;)Z", "")]
		public static unsafe bool Copy (global::System.IO.Stream @in, string toPath)
		{
			if (id_copy_Ljava_io_InputStream_Ljava_lang_String_ == IntPtr.Zero)
				id_copy_Ljava_io_InputStream_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "copy", "(Ljava/io/InputStream;Ljava/lang/String;)Z");
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			IntPtr native_toPath = JNIEnv.NewString (toPath);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native__in);
				__args [1] = new JValue (native_toPath);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_copy_Ljava_io_InputStream_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
				JNIEnv.DeleteLocalRef (native_toPath);
			}
		}

		static IntPtr id_copy_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool Copy (string fromPath, string toPath)
		{
			if (id_copy_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_copy_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "copy", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_fromPath = JNIEnv.NewString (fromPath);
			IntPtr native_toPath = JNIEnv.NewString (toPath);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_fromPath);
				__args [1] = new JValue (native_toPath);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_copy_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fromPath);
				JNIEnv.DeleteLocalRef (native_toPath);
			}
		}

		static IntPtr id_copyFile_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='copyFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("copyFile", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool CopyFile (string sourceFilePath, string destFilePath)
		{
			if (id_copyFile_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_copyFile_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "copyFile", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_sourceFilePath = JNIEnv.NewString (sourceFilePath);
			IntPtr native_destFilePath = JNIEnv.NewString (destFilePath);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_sourceFilePath);
				__args [1] = new JValue (native_destFilePath);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_copyFile_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceFilePath);
				JNIEnv.DeleteLocalRef (native_destFilePath);
			}
		}

		static IntPtr id_deleteFile_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='deleteFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("deleteFile", "(Ljava/io/File;)Z", "")]
		public static unsafe bool DeleteFile (global::Java.IO.File file)
		{
			if (id_deleteFile_Ljava_io_File_ == IntPtr.Zero)
				id_deleteFile_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "deleteFile", "(Ljava/io/File;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (file);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_deleteFile_Ljava_io_File_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_deleteFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='deleteFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteFile", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool DeleteFile (string path)
		{
			if (id_deleteFile_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteFile_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "deleteFile", "(Ljava/lang/String;)Z");
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_path);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_deleteFile_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static IntPtr id_getDataDir_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='getDataDir' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDataDir", "(Landroid/content/Context;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File GetDataDir (global::Android.Content.Context context)
		{
			if (id_getDataDir_Landroid_content_Context_ == IntPtr.Zero)
				id_getDataDir_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getDataDir", "(Landroid/content/Context;)Ljava/io/File;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDataDir_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFileExtension_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='getFileExtension' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFileExtension", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetFileExtension (string filePath)
		{
			if (id_getFileExtension_Ljava_lang_String_ == IntPtr.Zero)
				id_getFileExtension_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getFileExtension", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_filePath);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFileExtension_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		static IntPtr id_getFileName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='getFileName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFileName", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetFileName (string filePath)
		{
			if (id_getFileName_Ljava_lang_String_ == IntPtr.Zero)
				id_getFileName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getFileName", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_filePath);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFileName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		static IntPtr id_getFileNameWithoutExtension_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='getFileNameWithoutExtension' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFileNameWithoutExtension", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetFileNameWithoutExtension (string filePath)
		{
			if (id_getFileNameWithoutExtension_Ljava_lang_String_ == IntPtr.Zero)
				id_getFileNameWithoutExtension_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getFileNameWithoutExtension", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_filePath);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFileNameWithoutExtension_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		static IntPtr id_getFileOrDirSize_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='getFileOrDirSize' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getFileOrDirSize", "(Ljava/io/File;)J", "")]
		public static unsafe long GetFileOrDirSize (global::Java.IO.File file)
		{
			if (id_getFileOrDirSize_Ljava_io_File_ == IntPtr.Zero)
				id_getFileOrDirSize_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "getFileOrDirSize", "(Ljava/io/File;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (file);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getFileOrDirSize_Ljava_io_File_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFileSize_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='getFileSize' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFileSize", "(Ljava/lang/String;)J", "")]
		public static unsafe long GetFileSize (string path)
		{
			if (id_getFileSize_Ljava_lang_String_ == IntPtr.Zero)
				id_getFileSize_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getFileSize", "(Ljava/lang/String;)J");
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_path);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getFileSize_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static IntPtr id_getFolderName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='getFolderName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFolderName", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetFolderName (string filePath)
		{
			if (id_getFolderName_Ljava_lang_String_ == IntPtr.Zero)
				id_getFolderName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getFolderName", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_filePath);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFolderName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		static IntPtr id_hasSDCardPermission_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='hasSDCardPermission' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("hasSDCardPermission", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool HasSDCardPermission (global::Android.Content.Context context)
		{
			if (id_hasSDCardPermission_Landroid_content_Context_ == IntPtr.Zero)
				id_hasSDCardPermission_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "hasSDCardPermission", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasSDCardPermission_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isFileExist_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='isFileExist' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isFileExist", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsFileExist (string filePath)
		{
			if (id_isFileExist_Ljava_lang_String_ == IntPtr.Zero)
				id_isFileExist_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isFileExist", "(Ljava/lang/String;)Z");
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_filePath);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isFileExist_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		static IntPtr id_isFolderExist_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='isFolderExist' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isFolderExist", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsFolderExist (string directoryPath)
		{
			if (id_isFolderExist_Ljava_lang_String_ == IntPtr.Zero)
				id_isFolderExist_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isFolderExist", "(Ljava/lang/String;)Z");
			IntPtr native_directoryPath = JNIEnv.NewString (directoryPath);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_directoryPath);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isFolderExist_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_directoryPath);
			}
		}

		static IntPtr id_makeDirs_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='makeDirs' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeDirs", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool MakeDirs (string filePath)
		{
			if (id_makeDirs_Ljava_lang_String_ == IntPtr.Zero)
				id_makeDirs_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "makeDirs", "(Ljava/lang/String;)Z");
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_filePath);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_makeDirs_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		static IntPtr id_makeFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='makeFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeFile", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool MakeFile (string filePath)
		{
			if (id_makeFile_Ljava_lang_String_ == IntPtr.Zero)
				id_makeFile_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "makeFile", "(Ljava/lang/String;)Z");
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_filePath);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_makeFile_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		static IntPtr id_makeFolders_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='makeFolders' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeFolders", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool MakeFolders (string filePath)
		{
			if (id_makeFolders_Ljava_lang_String_ == IntPtr.Zero)
				id_makeFolders_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "makeFolders", "(Ljava/lang/String;)Z");
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_filePath);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_makeFolders_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		static IntPtr id_moveFile_Ljava_io_File_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='moveFile' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.io.File']]"
		[Register ("moveFile", "(Ljava/io/File;Ljava/io/File;)V", "")]
		public static unsafe void MoveFile (global::Java.IO.File srcFile, global::Java.IO.File destFile)
		{
			if (id_moveFile_Ljava_io_File_Ljava_io_File_ == IntPtr.Zero)
				id_moveFile_Ljava_io_File_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "moveFile", "(Ljava/io/File;Ljava/io/File;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (srcFile);
				__args [1] = new JValue (destFile);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_moveFile_Ljava_io_File_Ljava_io_File_, __args);
			} finally {
			}
		}

		static IntPtr id_moveFile_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='moveFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("moveFile", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void MoveFile (string sourceFilePath, string destFilePath)
		{
			if (id_moveFile_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_moveFile_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "moveFile", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_sourceFilePath = JNIEnv.NewString (sourceFilePath);
			IntPtr native_destFilePath = JNIEnv.NewString (destFilePath);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_sourceFilePath);
				__args [1] = new JValue (native_destFilePath);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_moveFile_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceFilePath);
				JNIEnv.DeleteLocalRef (native_destFilePath);
			}
		}

		static IntPtr id_readFile_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='readFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("readFile", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/StringBuilder;", "")]
		public static unsafe global::Java.Lang.StringBuilder ReadFile (string filePath, string charsetName)
		{
			if (id_readFile_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_readFile_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "readFile", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/StringBuilder;");
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			IntPtr native_charsetName = JNIEnv.NewString (charsetName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_filePath);
				__args [1] = new JValue (native_charsetName);
				global::Java.Lang.StringBuilder __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readFile_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
				JNIEnv.DeleteLocalRef (native_charsetName);
			}
		}

		static IntPtr id_readFileToList_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='readFileToList' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("readFileToList", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> ReadFileToList (string filePath, string charsetName)
		{
			if (id_readFileToList_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_readFileToList_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "readFileToList", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			IntPtr native_charsetName = JNIEnv.NewString (charsetName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_filePath);
				__args [1] = new JValue (native_charsetName);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_readFileToList_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
				JNIEnv.DeleteLocalRef (native_charsetName);
			}
		}

		static IntPtr id_readToString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='readToString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("readToString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ReadToString (string filePath, string charset)
		{
			if (id_readToString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_readToString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "readToString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			IntPtr native_charset = JNIEnv.NewString (charset);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_filePath);
				__args [1] = new JValue (native_charset);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_readToString_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
				JNIEnv.DeleteLocalRef (native_charset);
			}
		}

		static IntPtr id_writeFile_Ljava_io_File_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='writeFile' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("writeFile", "(Ljava/io/File;Ljava/io/InputStream;)Z", "")]
		public static unsafe bool WriteFile (global::Java.IO.File file, global::System.IO.Stream stream)
		{
			if (id_writeFile_Ljava_io_File_Ljava_io_InputStream_ == IntPtr.Zero)
				id_writeFile_Ljava_io_File_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "writeFile", "(Ljava/io/File;Ljava/io/InputStream;)Z");
			IntPtr native_stream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (stream);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (file);
				__args [1] = new JValue (native_stream);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_writeFile_Ljava_io_File_Ljava_io_InputStream_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_stream);
			}
		}

		static IntPtr id_writeFile_Ljava_io_File_Ljava_io_InputStream_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='writeFile' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.io.InputStream'] and parameter[3][@type='boolean']]"
		[Register ("writeFile", "(Ljava/io/File;Ljava/io/InputStream;Z)Z", "")]
		public static unsafe bool WriteFile (global::Java.IO.File file, global::System.IO.Stream stream, bool append)
		{
			if (id_writeFile_Ljava_io_File_Ljava_io_InputStream_Z == IntPtr.Zero)
				id_writeFile_Ljava_io_File_Ljava_io_InputStream_Z = JNIEnv.GetStaticMethodID (class_ref, "writeFile", "(Ljava/io/File;Ljava/io/InputStream;Z)Z");
			IntPtr native_stream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (stream);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (file);
				__args [1] = new JValue (native_stream);
				__args [2] = new JValue (append);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_writeFile_Ljava_io_File_Ljava_io_InputStream_Z, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_stream);
			}
		}

		static IntPtr id_writeFile_Ljava_lang_String_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='writeFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("writeFile", "(Ljava/lang/String;Ljava/io/InputStream;)Z", "")]
		public static unsafe bool WriteFile (string filePath, global::System.IO.Stream stream)
		{
			if (id_writeFile_Ljava_lang_String_Ljava_io_InputStream_ == IntPtr.Zero)
				id_writeFile_Ljava_lang_String_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "writeFile", "(Ljava/lang/String;Ljava/io/InputStream;)Z");
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			IntPtr native_stream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (stream);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_filePath);
				__args [1] = new JValue (native_stream);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_writeFile_Ljava_lang_String_Ljava_io_InputStream_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
				JNIEnv.DeleteLocalRef (native_stream);
			}
		}

		static IntPtr id_writeFile_Ljava_lang_String_Ljava_io_InputStream_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='writeFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.InputStream'] and parameter[3][@type='boolean']]"
		[Register ("writeFile", "(Ljava/lang/String;Ljava/io/InputStream;Z)Z", "")]
		public static unsafe bool WriteFile (string filePath, global::System.IO.Stream stream, bool append)
		{
			if (id_writeFile_Ljava_lang_String_Ljava_io_InputStream_Z == IntPtr.Zero)
				id_writeFile_Ljava_lang_String_Ljava_io_InputStream_Z = JNIEnv.GetStaticMethodID (class_ref, "writeFile", "(Ljava/lang/String;Ljava/io/InputStream;Z)Z");
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			IntPtr native_stream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (stream);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_filePath);
				__args [1] = new JValue (native_stream);
				__args [2] = new JValue (append);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_writeFile_Ljava_lang_String_Ljava_io_InputStream_Z, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
				JNIEnv.DeleteLocalRef (native_stream);
			}
		}

		static IntPtr id_writeFile_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='writeFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("writeFile", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool WriteFile (string filePath, string content)
		{
			if (id_writeFile_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_writeFile_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "writeFile", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			IntPtr native_content = JNIEnv.NewString (content);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_filePath);
				__args [1] = new JValue (native_content);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_writeFile_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
				JNIEnv.DeleteLocalRef (native_content);
			}
		}

		static IntPtr id_writeFile_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='writeFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("writeFile", "(Ljava/lang/String;Ljava/lang/String;Z)Z", "")]
		public static unsafe bool WriteFile (string filePath, string content, bool append)
		{
			if (id_writeFile_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_writeFile_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "writeFile", "(Ljava/lang/String;Ljava/lang/String;Z)Z");
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			IntPtr native_content = JNIEnv.NewString (content);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_filePath);
				__args [1] = new JValue (native_content);
				__args [2] = new JValue (append);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_writeFile_Ljava_lang_String_Ljava_lang_String_Z, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
				JNIEnv.DeleteLocalRef (native_content);
			}
		}

		static IntPtr id_writeFile_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='writeFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("writeFile", "(Ljava/lang/String;Ljava/util/List;)Z", "")]
		public static unsafe bool WriteFile (string filePath, global::System.Collections.Generic.IList<string> contentList)
		{
			if (id_writeFile_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_writeFile_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "writeFile", "(Ljava/lang/String;Ljava/util/List;)Z");
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			IntPtr native_contentList = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (contentList);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_filePath);
				__args [1] = new JValue (native_contentList);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_writeFile_Ljava_lang_String_Ljava_util_List_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
				JNIEnv.DeleteLocalRef (native_contentList);
			}
		}

		static IntPtr id_writeFile_Ljava_lang_String_Ljava_util_List_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='writeFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[3][@type='boolean']]"
		[Register ("writeFile", "(Ljava/lang/String;Ljava/util/List;Z)Z", "")]
		public static unsafe bool WriteFile (string filePath, global::System.Collections.Generic.IList<string> contentList, bool append)
		{
			if (id_writeFile_Ljava_lang_String_Ljava_util_List_Z == IntPtr.Zero)
				id_writeFile_Ljava_lang_String_Ljava_util_List_Z = JNIEnv.GetStaticMethodID (class_ref, "writeFile", "(Ljava/lang/String;Ljava/util/List;Z)Z");
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			IntPtr native_contentList = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (contentList);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_filePath);
				__args [1] = new JValue (native_contentList);
				__args [2] = new JValue (append);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_writeFile_Ljava_lang_String_Ljava_util_List_Z, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
				JNIEnv.DeleteLocalRef (native_contentList);
			}
		}

	}
}
