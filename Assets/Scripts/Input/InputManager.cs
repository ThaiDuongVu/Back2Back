// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/InputManager.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputManager : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputManager"",
    ""maps"": [
        {
            ""name"": ""Game"",
            ""id"": ""455691d7-03ef-4292-a419-9be4dc3a3478"",
            ""actions"": [
                {
                    ""name"": ""Direction"",
                    ""type"": ""Button"",
                    ""id"": ""8bdd22ca-3c57-40cd-81e7-974f687b6bb8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""f00de01e-762d-4477-ab14-520b6b3e2c30"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""b95f3d4c-fc07-4100-9884-6f3794dcb673"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Test"",
                    ""type"": ""Button"",
                    ""id"": ""c1897279-3d6f-4afc-8124-d4f990934bce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""547e99fd-a45f-42e5-aa05-df7e06805a81"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""69fa878d-4f33-4fee-96e0-2b7d7bc2caab"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1e70df2f-73dc-4ba7-b819-fb0a56509f9e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""223ad6a4-7c07-4acc-a4d6-0d79f9ec055c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5f3fbb01-6e1c-4d36-ae26-1c4e55a32a7d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""7ea48cdf-6b8c-4f33-9497-b1626fae5a9e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""59b94738-70b1-468d-aa6a-5322baae21ca"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7bcacc5b-3711-4742-9655-7920a97512ac"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""48149d48-ee76-487a-bc20-1daab6c27d98"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e61f5bbb-b46c-4c52-885b-3f3dacc76a10"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPad"",
                    ""id"": ""17b9f16a-0d0d-4515-a64f-3a0e7e46f561"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""47d03bb6-a8f5-4525-af18-4a7a82f0f506"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""73575ea1-7050-4589-a7f5-f047d7312f69"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5c4e4644-c9e3-4f39-9253-9c2fea91e296"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""36b25403-0ad0-4c6d-a5b4-fbd5b6b1a9a1"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3defcf81-55df-4e4e-96ba-564219ad0bb9"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70a766cd-1723-4fbc-ae4e-f76fe5256f48"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5d78d33-c1f4-47aa-9f9c-f5d7665d43c2"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90f65077-7e49-4832-b035-68f14d09b689"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4bb6fc22-d9ea-4067-949e-6cf20166d4e6"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Test"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player"",
            ""id"": ""883c81b4-147f-4155-957c-14f724213da6"",
            ""actions"": [
                {
                    ""name"": ""MoveKeyboard"",
                    ""type"": ""Button"",
                    ""id"": ""9c3d8cee-edc2-45a3-81b2-0e2b72c534bf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveGamepad"",
                    ""type"": ""Value"",
                    ""id"": ""419c31cc-c587-4e19-b76f-dd71017e9049"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""1155563b-6baa-44fd-9079-0b1e5ca86156"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""3d9825f7-e13f-4882-baaa-d0b2bd9d95ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrows"",
                    ""id"": ""be0efb98-ed08-4846-a5be-4e5f58427baa"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKeyboard"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2f3d675c-0c6c-4fc8-ae12-d52a1bace368"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""MoveKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""709f193a-e132-4e52-986c-19183dec1eb2"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""MoveKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""38733c66-c585-44ac-9461-ab3c585f32f3"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""MoveKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c0f80788-4cb4-4d20-a74c-b94a8d57d243"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""MoveKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""bba4c585-e6bb-472d-ad24-cc90ca155e1c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""MoveKeyboard"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1b7be4bc-5af7-43a0-afd5-0241ef2eb901"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""MoveKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f9d94f29-8c04-4c30-aa3c-dc12504a1ebc"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""MoveKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b7c707e6-d848-49fb-a498-0daf34241c54"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""MoveKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ba85c3ac-117d-4e39-9f4a-8086bcb81782"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""MoveKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""6a4730bf-74f0-41d3-bd2d-4a6480df9b2c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveGamepad"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e55f7aae-3070-403c-9d7a-1b55a7319fbe"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveGamepad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""eeb3f45f-0abe-4edd-b26c-56ed47d0afd2"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveGamepad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""313c97a1-2687-49a5-a3c2-0914644939fa"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveGamepad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""02562d5a-7da4-4691-a231-391eebad5c64"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveGamepad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""RightStick"",
                    ""id"": ""98abf188-b484-461e-9d70-e17419eac1f3"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3df46d3c-1955-48a6-b467-6b88036439f6"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e24bbe79-9211-4d61-a247-91a1418c12c2"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""57fc5d68-d3f0-4652-8f03-4ae45926e0ff"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=2.5),Invert"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""72724ea5-d93e-4b57-8a6d-5c5383d41d0e"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=2.5),Invert"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Mouse"",
                    ""id"": ""47d65928-73d5-4b84-af5e-69ba3148c017"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d4793dc4-79c1-48e6-8289-9d348609f483"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""47cf2185-4a69-447b-b785-0f6f7dfb9ee7"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b885b0ae-5fd3-4c55-98c4-481a5222da8d"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": ""Normalize(min=1),Scale(factor=0.05)"",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d48b1b52-902d-4683-b429-32410846d38c"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": ""Normalize(max=1),Scale(factor=0.05)"",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f29b6dc8-40c9-4bd0-9481-4f27b1edd38f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90b94418-542a-41f8-88ce-ef504f373836"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""MouseKeyboard"",
            ""bindingGroup"": ""MouseKeyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Game
        m_Game = asset.FindActionMap("Game", throwIfNotFound: true);
        m_Game_Direction = m_Game.FindAction("Direction", throwIfNotFound: true);
        m_Game_Click = m_Game.FindAction("Click", throwIfNotFound: true);
        m_Game_Escape = m_Game.FindAction("Escape", throwIfNotFound: true);
        m_Game_Test = m_Game.FindAction("Test", throwIfNotFound: true);
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_MoveKeyboard = m_Player.FindAction("MoveKeyboard", throwIfNotFound: true);
        m_Player_MoveGamepad = m_Player.FindAction("MoveGamepad", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Fire = m_Player.FindAction("Fire", throwIfNotFound: true);
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

    // Game
    private readonly InputActionMap m_Game;
    private IGameActions m_GameActionsCallbackInterface;
    private readonly InputAction m_Game_Direction;
    private readonly InputAction m_Game_Click;
    private readonly InputAction m_Game_Escape;
    private readonly InputAction m_Game_Test;
    public struct GameActions
    {
        private @InputManager m_Wrapper;
        public GameActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Direction => m_Wrapper.m_Game_Direction;
        public InputAction @Click => m_Wrapper.m_Game_Click;
        public InputAction @Escape => m_Wrapper.m_Game_Escape;
        public InputAction @Test => m_Wrapper.m_Game_Test;
        public InputActionMap Get() { return m_Wrapper.m_Game; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
        public void SetCallbacks(IGameActions instance)
        {
            if (m_Wrapper.m_GameActionsCallbackInterface != null)
            {
                @Direction.started -= m_Wrapper.m_GameActionsCallbackInterface.OnDirection;
                @Direction.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnDirection;
                @Direction.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnDirection;
                @Click.started -= m_Wrapper.m_GameActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnClick;
                @Escape.started -= m_Wrapper.m_GameActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnEscape;
                @Test.started -= m_Wrapper.m_GameActionsCallbackInterface.OnTest;
                @Test.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnTest;
                @Test.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnTest;
            }
            m_Wrapper.m_GameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Direction.started += instance.OnDirection;
                @Direction.performed += instance.OnDirection;
                @Direction.canceled += instance.OnDirection;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
                @Test.started += instance.OnTest;
                @Test.performed += instance.OnTest;
                @Test.canceled += instance.OnTest;
            }
        }
    }
    public GameActions @Game => new GameActions(this);

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_MoveKeyboard;
    private readonly InputAction m_Player_MoveGamepad;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Fire;
    public struct PlayerActions
    {
        private @InputManager m_Wrapper;
        public PlayerActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveKeyboard => m_Wrapper.m_Player_MoveKeyboard;
        public InputAction @MoveGamepad => m_Wrapper.m_Player_MoveGamepad;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Fire => m_Wrapper.m_Player_Fire;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @MoveKeyboard.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveKeyboard;
                @MoveKeyboard.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveKeyboard;
                @MoveKeyboard.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveKeyboard;
                @MoveGamepad.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveGamepad;
                @MoveGamepad.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveGamepad;
                @MoveGamepad.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveGamepad;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Fire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveKeyboard.started += instance.OnMoveKeyboard;
                @MoveKeyboard.performed += instance.OnMoveKeyboard;
                @MoveKeyboard.canceled += instance.OnMoveKeyboard;
                @MoveGamepad.started += instance.OnMoveGamepad;
                @MoveGamepad.performed += instance.OnMoveGamepad;
                @MoveGamepad.canceled += instance.OnMoveGamepad;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_MouseKeyboardSchemeIndex = -1;
    public InputControlScheme MouseKeyboardScheme
    {
        get
        {
            if (m_MouseKeyboardSchemeIndex == -1) m_MouseKeyboardSchemeIndex = asset.FindControlSchemeIndex("MouseKeyboard");
            return asset.controlSchemes[m_MouseKeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IGameActions
    {
        void OnDirection(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnEscape(InputAction.CallbackContext context);
        void OnTest(InputAction.CallbackContext context);
    }
    public interface IPlayerActions
    {
        void OnMoveKeyboard(InputAction.CallbackContext context);
        void OnMoveGamepad(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
    }
}
