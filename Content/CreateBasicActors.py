import unreal

asset_tools = unreal.AssetToolsHelpers.get_asset_tools()

source_path = "/Game/NewBlueprint"     # Path to your original BP
destination_folder = "/Game/Advanced"  # Folder for the copies

# Make sure the folder exists
unreal.EditorAssetLibrary.make_directory(destination_folder)

for i in range(1, 10001):  # 1 to 10000
    new_name = f"BP_Copy_{i:05d}"  # zero-padded numbering
    print(f"Creating {new_name}...")
    asset_tools.duplicate_asset(
        new_name,
        destination_folder,
        unreal.EditorAssetLibrary.load_asset(source_path)
    )

print("✅ Done creating 10,000 copies!")
