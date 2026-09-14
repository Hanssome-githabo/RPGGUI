using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGUI
{
    public class JsonStorage : IDataStorage
    {
        // 1. 把RPGModel里那份JsonSeriallize 搬过来，作为私有字段
        #region 全局翻译配置
        private static readonly JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true, // 让生成的 JSON 文件有缩进，好看
            IncludeFields = true,  // 告诉 JSON 库把字段也当作属性一样处理
            Converters = { new JsonStringEnumConverter() }// 让枚举显示为文字
        };
        #endregion

        #region 保存json
        // 泛型参数 T 允许我们在保存时传入任何实现了 ISaveable 接口的对象列表。
        // 约束 where T : ISaveable 确保传入的类型必须实现 ISaveable 接口。
        public void SaveGame<T>(List<T> saveables) where T : ISaveable
        {
            string jsonString = JsonSerializer.Serialize(saveables, options);
            File.WriteAllText("save.json", jsonString);
            //Console.WriteLine("游戏已保存！");
        }
        #endregion

        #region 读取json
        public List<T> LoadGame<T>() where T : ISaveable
        {
            if (!File.Exists("save.json")) return null;
            // 2. 读取文件里的 JSON 字符串
            string jsonString = File.ReadAllText("save.json");
            // 3. 把 JSON 字符串反翻译回对象列表（使用同样的 options）
            return JsonSerializer.Deserialize<List<T>>(jsonString, options);
        }
        #endregion
    }
}
