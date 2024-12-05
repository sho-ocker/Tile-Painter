//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/ControlMapping.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @ControlMapping: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControlMapping()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ControlMapping"",
    ""maps"": [
        {
            ""name"": ""PlayerCharacter"",
            ""id"": ""a8b10666-f287-420b-80f9-88fe10604b39"",
            ""actions"": [
                {
                    ""name"": ""VerticalMovement"",
                    ""type"": ""Button"",
                    ""id"": ""e2fb1121-da1f-4c79-a24c-912b59eb407a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""HorizontalMovement"",
                    ""type"": ""Button"",
                    ""id"": ""325192da-f4b0-4636-9552-6239e51d8dc3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""0d6c8a78-9622-4dad-ac8c-8214ae4ce258"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8b5c054d-1c97-4fa8-8534-b286545077ac"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""362ed965-cd25-4517-9803-c49b4bafeead"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e2f77083-c0d4-4a3c-bb5b-2c4a7984ab6b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""83baac8c-e917-4810-bb50-b6d702476aee"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""39b47370-42a1-47d6-8975-fd4d7f7984f0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""adbe8673-9f2e-47f1-b9b8-2c37afe02513"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""549652dc-7ecd-43a6-8d32-1411cd353953"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerCharacter
        m_PlayerCharacter = asset.FindActionMap("PlayerCharacter", throwIfNotFound: true);
        m_PlayerCharacter_VerticalMovement = m_PlayerCharacter.FindAction("VerticalMovement", throwIfNotFound: true);
        m_PlayerCharacter_HorizontalMovement = m_PlayerCharacter.FindAction("HorizontalMovement", throwIfNotFound: true);
        m_PlayerCharacter_Interaction = m_PlayerCharacter.FindAction("Interaction", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerCharacter
    private readonly InputActionMap m_PlayerCharacter;
    private List<IPlayerCharacterActions> m_PlayerCharacterActionsCallbackInterfaces = new List<IPlayerCharacterActions>();
    private readonly InputAction m_PlayerCharacter_VerticalMovement;
    private readonly InputAction m_PlayerCharacter_HorizontalMovement;
    private readonly InputAction m_PlayerCharacter_Interaction;
    public struct PlayerCharacterActions
    {
        private @ControlMapping m_Wrapper;
        public PlayerCharacterActions(@ControlMapping wrapper) { m_Wrapper = wrapper; }
        public InputAction @VerticalMovement => m_Wrapper.m_PlayerCharacter_VerticalMovement;
        public InputAction @HorizontalMovement => m_Wrapper.m_PlayerCharacter_HorizontalMovement;
        public InputAction @Interaction => m_Wrapper.m_PlayerCharacter_Interaction;
        public InputActionMap Get() { return m_Wrapper.m_PlayerCharacter; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerCharacterActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerCharacterActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerCharacterActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerCharacterActionsCallbackInterfaces.Add(instance);
            @VerticalMovement.started += instance.OnVerticalMovement;
            @VerticalMovement.performed += instance.OnVerticalMovement;
            @VerticalMovement.canceled += instance.OnVerticalMovement;
            @HorizontalMovement.started += instance.OnHorizontalMovement;
            @HorizontalMovement.performed += instance.OnHorizontalMovement;
            @HorizontalMovement.canceled += instance.OnHorizontalMovement;
            @Interaction.started += instance.OnInteraction;
            @Interaction.performed += instance.OnInteraction;
            @Interaction.canceled += instance.OnInteraction;
        }

        private void UnregisterCallbacks(IPlayerCharacterActions instance)
        {
            @VerticalMovement.started -= instance.OnVerticalMovement;
            @VerticalMovement.performed -= instance.OnVerticalMovement;
            @VerticalMovement.canceled -= instance.OnVerticalMovement;
            @HorizontalMovement.started -= instance.OnHorizontalMovement;
            @HorizontalMovement.performed -= instance.OnHorizontalMovement;
            @HorizontalMovement.canceled -= instance.OnHorizontalMovement;
            @Interaction.started -= instance.OnInteraction;
            @Interaction.performed -= instance.OnInteraction;
            @Interaction.canceled -= instance.OnInteraction;
        }

        public void RemoveCallbacks(IPlayerCharacterActions instance)
        {
            if (m_Wrapper.m_PlayerCharacterActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerCharacterActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerCharacterActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerCharacterActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerCharacterActions @PlayerCharacter => new PlayerCharacterActions(this);
    public interface IPlayerCharacterActions
    {
        void OnVerticalMovement(InputAction.CallbackContext context);
        void OnHorizontalMovement(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
    }
}