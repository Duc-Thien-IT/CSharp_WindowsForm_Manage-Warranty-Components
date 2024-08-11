using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySuaChuaBaoHanh
{
	public partial class frmSetting : Form
	{
		private IMongoCollection<BsonDocument> _userCollection;

		public frmSetting()
		{
			InitializeComponent();
			InitializeMongoDB();
		}

		private void InitializeMongoDB()
		{
			var client = new MongoClient("mongodb://localhost:27017");
			var database = client.GetDatabase("QLBH");
			_userCollection = database.GetCollection<BsonDocument>("User");
		}

		private async void BackupData(string backupFilePath)
		{
			var allDocuments = await _userCollection.Find(new BsonDocument()).ToListAsync();
			var jsonBackup = allDocuments.ToJson();
			File.WriteAllText(backupFilePath, jsonBackup);
			MessageBox.Show("Backup completed successfully.");
		}

		private async void RestoreData(string backupFilePath)
		{
			var jsonBackup = File.ReadAllText(backupFilePath);
			var bsonArray = BsonSerializer.Deserialize<BsonArray>(jsonBackup);
			var bsonDocuments = bsonArray.Select(bsonValue => bsonValue.AsBsonDocument).ToList();
			await _userCollection.DeleteManyAsync(new BsonDocument()); // Clear existing data
			await _userCollection.InsertManyAsync(bsonDocuments);
			MessageBox.Show("Restore completed successfully.");
		}

		private void btnBackup_Click(object sender, EventArgs e)
		{
			var saveFileDialog = new SaveFileDialog
			{
				Filter = "JSON Files (*.json)|*.json",
				Title = "Save Backup File"
			};

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				BackupData(saveFileDialog.FileName);
			}
		}

		private void btnRestore_Click(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog
			{
				Filter = "JSON Files (*.json)|*.json",
				Title = "Open Backup File"
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				RestoreData(openFileDialog.FileName);
			}
		}
	}
}
