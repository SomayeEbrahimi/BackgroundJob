using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Repository.Local.Database.Room {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/interface[@name='IRoomDeviceDAO']"
	[Register ("com/vivalnk/sdk/repository/local/database/room/IRoomDeviceDAO", "", "Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDeviceDAOInvoker")]
	public partial interface IRoomDeviceDAO : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/interface[@name='IRoomDeviceDAO']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.repository.local.database.room.VitalDevice_Room...']]"
		[Register ("delete", "([Lcom/vivalnk/sdk/repository/local/database/room/VitalDevice_Room;)V", "GetDelete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_Handler:Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDeviceDAOInvoker, ECGCoreSDK")]
		void Delete (params global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDevice_Room[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/interface[@name='IRoomDeviceDAO']/method[@name='deleteAll' and count(parameter)=0]"
		[Register ("deleteAll", "()V", "GetDeleteAllHandler:Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDeviceDAOInvoker, ECGCoreSDK")]
		void DeleteAll ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/interface[@name='IRoomDeviceDAO']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.repository.local.database.room.VitalDevice_Room...']]"
		[Register ("insert", "([Lcom/vivalnk/sdk/repository/local/database/room/VitalDevice_Room;)V", "GetInsert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_Handler:Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDeviceDAOInvoker, ECGCoreSDK")]
		void Insert (params global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDevice_Room[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/interface[@name='IRoomDeviceDAO']/method[@name='query' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("query", "(Ljava/lang/String;)Lcom/vivalnk/sdk/repository/local/database/room/VitalDevice_Room;", "GetQuery_Ljava_lang_String_Handler:Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDeviceDAOInvoker, ECGCoreSDK")]
		global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDevice_Room Query (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/interface[@name='IRoomDeviceDAO']/method[@name='queryAll' and count(parameter)=0]"
		[Register ("queryAll", "()Ljava/util/List;", "GetQueryAllHandler:Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDeviceDAOInvoker, ECGCoreSDK")]
		global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDevice_Room> QueryAll ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/interface[@name='IRoomDeviceDAO']/method[@name='update' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.repository.local.database.room.VitalDevice_Room...']]"
		[Register ("update", "([Lcom/vivalnk/sdk/repository/local/database/room/VitalDevice_Room;)V", "GetUpdate_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_Handler:Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDeviceDAOInvoker, ECGCoreSDK")]
		void Update (params global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDevice_Room[] p0);

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/repository/local/database/room/IRoomDeviceDAO", DoNotGenerateAcw=true)]
	internal partial class IRoomDeviceDAOInvoker : global::Java.Lang.Object, IRoomDeviceDAO {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/repository/local/database/room/IRoomDeviceDAO", typeof (IRoomDeviceDAOInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IRoomDeviceDAO GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRoomDeviceDAO> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.repository.local.database.room.IRoomDeviceDAO"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRoomDeviceDAOInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_;
#pragma warning disable 0169
		static Delegate GetDelete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_Handler ()
		{
			if (cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_ == null)
				cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Delete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_);
			return cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_;
		}

		static void n_Delete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDeviceDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDevice_Room[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDevice_Room));
			__this.Delete (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_delete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_;
		public unsafe void Delete (params global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDevice_Room[] p0)
		{
			if (id_delete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_ == IntPtr.Zero)
				id_delete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_ = JNIEnv.GetMethodID (class_ref, "delete", "([Lcom/vivalnk/sdk/repository/local/database/room/VitalDevice_Room;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_deleteAll;
#pragma warning disable 0169
		static Delegate GetDeleteAllHandler ()
		{
			if (cb_deleteAll == null)
				cb_deleteAll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DeleteAll);
			return cb_deleteAll;
		}

		static void n_DeleteAll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDeviceDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteAll ();
		}
#pragma warning restore 0169

		IntPtr id_deleteAll;
		public unsafe void DeleteAll ()
		{
			if (id_deleteAll == IntPtr.Zero)
				id_deleteAll = JNIEnv.GetMethodID (class_ref, "deleteAll", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteAll);
		}

		static Delegate cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_;
#pragma warning disable 0169
		static Delegate GetInsert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_Handler ()
		{
			if (cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_ == null)
				cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Insert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_);
			return cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_;
		}

		static void n_Insert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDeviceDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDevice_Room[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDevice_Room));
			__this.Insert (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_insert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_;
		public unsafe void Insert (params global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDevice_Room[] p0)
		{
			if (id_insert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_ == IntPtr.Zero)
				id_insert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_ = JNIEnv.GetMethodID (class_ref, "insert", "([Lcom/vivalnk/sdk/repository/local/database/room/VitalDevice_Room;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_insert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_query_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQuery_Ljava_lang_String_Handler ()
		{
			if (cb_query_Ljava_lang_String_ == null)
				cb_query_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Query_Ljava_lang_String_);
			return cb_query_Ljava_lang_String_;
		}

		static IntPtr n_Query_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDeviceDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Query (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_query_Ljava_lang_String_;
		public unsafe global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDevice_Room Query (string p0)
		{
			if (id_query_Ljava_lang_String_ == IntPtr.Zero)
				id_query_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "query", "(Ljava/lang/String;)Lcom/vivalnk/sdk/repository/local/database/room/VitalDevice_Room;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDevice_Room> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_query_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_queryAll;
#pragma warning disable 0169
		static Delegate GetQueryAllHandler ()
		{
			if (cb_queryAll == null)
				cb_queryAll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_QueryAll);
			return cb_queryAll;
		}

		static IntPtr n_QueryAll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDeviceDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDevice_Room>.ToLocalJniHandle (__this.QueryAll ());
		}
#pragma warning restore 0169

		IntPtr id_queryAll;
		public unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDevice_Room> QueryAll ()
		{
			if (id_queryAll == IntPtr.Zero)
				id_queryAll = JNIEnv.GetMethodID (class_ref, "queryAll", "()Ljava/util/List;");
			return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDevice_Room>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_queryAll), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_update_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_;
#pragma warning disable 0169
		static Delegate GetUpdate_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_Handler ()
		{
			if (cb_update_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_ == null)
				cb_update_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Update_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_);
			return cb_update_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_;
		}

		static void n_Update_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDeviceDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDevice_Room[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDevice_Room));
			__this.Update (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_update_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_;
		public unsafe void Update (params global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDevice_Room[] p0)
		{
			if (id_update_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_ == IntPtr.Zero)
				id_update_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_ = JNIEnv.GetMethodID (class_ref, "update", "([Lcom/vivalnk/sdk/repository/local/database/room/VitalDevice_Room;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_update_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalDevice_Room_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
