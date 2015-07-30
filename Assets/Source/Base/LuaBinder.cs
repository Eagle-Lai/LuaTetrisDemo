﻿using System;

public static class LuaBinder
{
	public static void Bind(IntPtr L)
	{
		AnimationBlendModeWrap.Register(L);
		AnimationClipWrap.Register(L);
		AnimationStateWrap.Register(L);
		AnimationWrap.Register(L);
		AppConstWrap.Register(L);
		ApplicationWrap.Register(L);
		AssetBundleWrap.Register(L);
		AsyncOperationWrap.Register(L);
		AudioClipWrap.Register(L);
		AudioSourceWrap.Register(L);
		BehaviourWrap.Register(L);
		BlendWeightsWrap.Register(L);
		BoxColliderWrap.Register(L);
		CameraClearFlagsWrap.Register(L);
		CameraWrap.Register(L);
		CharacterControllerWrap.Register(L);
		ColliderWrap.Register(L);
		ComponentWrap.Register(L);
		DebuggerWrap.Register(L);
		DelegateFactoryWrap.Register(L);
		DelegateWrap.Register(L);
		EnumWrap.Register(L);
		GameObjectWrap.Register(L);
		GUILayerWrap.Register(L);
		GUILayoutWrap.Register(L);
		GUIWrap.Register(L);
		IEnumeratorWrap.Register(L);
		InputWrap.Register(L);
		KeyCodeWrap.Register(L);
		LightTypeWrap.Register(L);
		LightWrap.Register(L);
		LuaEnumTypeWrap.Register(L);
		MaterialWrap.Register(L);
		MeshColliderWrap.Register(L);
		MeshRendererWrap.Register(L);
		MonoBehaviourWrap.Register(L);
		ObjectWrap.Register(L);
		ParticleAnimatorWrap.Register(L);
		ParticleEmitterWrap.Register(L);
		ParticleRendererWrap.Register(L);
		ParticleSystemWrap.Register(L);
		PhysicsWrap.Register(L);
		PlayModeWrap.Register(L);
		QualitySettingsWrap.Register(L);
		QueueModeWrap.Register(L);
		RandomWrap.Register(L);
		RectTransformWrap.Register(L);
		RectWrap.Register(L);
		RendererWrap.Register(L);
		RenderSettingsWrap.Register(L);
		RenderTextureWrap.Register(L);
		ScreenWrap.Register(L);
		SkinnedMeshRendererWrap.Register(L);
		SleepTimeoutWrap.Register(L);
		SpaceWrap.Register(L);
		SphereColliderWrap.Register(L);
		stringWrap.Register(L);
		System_ObjectWrap.Register(L);
		TextureWrap.Register(L);
		TimeWrap.Register(L);
		TouchPhaseWrap.Register(L);
		TrackedReferenceWrap.Register(L);
		TransformWrap.Register(L);
		TypeWrap.Register(L);
		UnityEngine_UI_TextWrap.Register(L);
		UtilWrap.Register(L);
	}
}
