using System.Collections.Generic;
using System.Drawing;

namespace FastCodeSNILBot
{
    public class Model
    {
        public enum OperationMode
        {
            /// <summary>
            /// Режим выделения шаблонов
            /// </summary>
            TemplatesSelecting,
            /// <summary>
            /// Режим очистки ячейки от выделения
            /// </summary>
            SelectingRemove,
            /// <summary>
            /// Режим удаления команды
            /// </summary>
            DeletingCommand,
            /// <summary>
            /// Режим замены команды
            /// </summary>
            ReplaceCommand,
            /// <summary>
            /// Режим "пулемета"
            /// </summary>
            MashineGun
        }

        /// <summary>
        /// Указывает на возможность рисования рамки ячейки
        /// </summary>
        public enum RepaintingCellStatus
        {
            /// <summary>
            /// В ячейку добавлена иконка команды
            /// </summary>
            WithValue,
            /// <summary>
            /// В ячейке содержится только фоновое значение
            /// </summary>
            WithoutValue
        }

        public enum BotType
        {
            Humanoid,
            Collector
        }

        public class CellForRepaint
        {
            public int row;
            public int collumn;
            //public Color color;
            public List<Color> colors = new List<Color>();
        }

        public class CommandCellTag
        {
            public int icon_index;
            public RepaintingCellStatus repainting_status;
            public CommandCellTag() 
            {
                icon_index = -1;
                repainting_status = RepaintingCellStatus.WithoutValue;
            }
        }

        public const int COMMANDS_COUNT = 5;
        public const int COMMAND_ICON_HEIGHT =70;
        public static int CELL_BORDER_WIDTH = 4;

        public const int MAX_COLUMNS_COUNT = 6;
        public static int command_row = 0;
        public static int command_col = 0;
        public static int current_command_row = 0;  
        public static int current_command_col = 0;

        public static int commands_count = 0;

        /// <summary>
        /// Иконки для всех ботов
        /// </summary>
        public static Dictionary<BotType, List<Bitmap[]>> bots_commands_icons = new Dictionary<BotType, List<Bitmap[]>>()
        {
            {
                BotType.Humanoid,
                new List<Bitmap[]>()
                {
                    new Bitmap[]
                    {
                        Properties.Resources.HumForward,
                        Properties.Resources.HumForwardSelected
                    },
                    new Bitmap[]
                    {
                        Properties.Resources.HumTurnLeft,
                        Properties.Resources.HumTurnLeftSelected
                    },
                    new Bitmap[]
                    {
                        Properties.Resources.HumTurnRight,
                        Properties.Resources.HumTurnRightSelected
                    },
                    new Bitmap[]
                    {
                        Properties.Resources.HumActivate,
                        Properties.Resources.HumActivateSelected
                    },
                    new Bitmap[]
                    {
                        Properties.Resources.HumJump,
                        Properties.Resources.HumJumpSelected
                    },
                    new Bitmap[]
                    {
                        Properties.Resources.HumScan,
                        Properties.Resources.HumScanSelected
                    }
                }
            },
            {
                BotType.Collector,
                new List<Bitmap[]>()
                {
                    new Bitmap[]
                    {
                        Properties.Resources.ColForward,
                        Properties.Resources.ColForwardSelected
                    },
                    new Bitmap[]
                    {
                        Properties.Resources.ColTurnBackWard,
                        Properties.Resources.ColTurnBackWardSelected
                    },
                    new Bitmap[]
                    {
                        Properties.Resources.ColTurnLeft,
                        Properties.Resources.ColTurnLeftSelected
                    },
                    new Bitmap[]
                    {
                        Properties.Resources.ColTurnRight,
                        Properties.Resources.ColTurnRightSelected
                    },
                    new Bitmap[]
                    {
                        Properties.Resources.ColActivate,
                        Properties.Resources.ColActivateSelected
                    },
                    new Bitmap[]
                    {
                        Properties.Resources.ColPick,
                        Properties.Resources.ColPickSelected
                    }
                }
            },
        };

        public static BotType current_bot_type = BotType.Humanoid;
        public static int current_command_icon_index = 0;

        /// <summary>
        /// Ячейки с границами в таблице с коммандами
        /// </summary>
        public static List<CellForRepaint> command_cells_for_repaint = new List<CellForRepaint>();

        /// <summary>
        /// Ячейки с границами в таблице с функциями
        /// </summary>
        public static List<CellForRepaint> function_cells_for_repaint = new List<CellForRepaint>();

        /// <summary>
        /// Доступные цвета для функций
        /// </summary>
        public static List<Color> enabled_colors = new List<Color>
        {
            Color.Red,
            Color.Blue,
            Color.Green,
            Color.Cyan,
            Color.Purple,
            Color.Chocolate,
            Color.Gold
        };

        /// <summary>
        /// Текщий цвет для отметки команды
        /// </summary>
        public static Color current_select_color;

        /// <summary>
        /// Текущий режим работы с таблицей команд
        /// </summary>
        public static OperationMode current_operation_mode = OperationMode.MashineGun;

        /// <summary>
        /// Номер строки текущей выбранной иконки команды
        /// </summary>
        public static int selected_command_icon_row = -1;

        /// <summary>
        /// Текущая выбранная ячейка с командой
        /// </summary>
        public static Point selected_command_cell;

        /// <summary>
        /// Текущая выбранная ячейка цвета для шаблонов
        /// </summary>
        public static int selected_color_cell_row = -1;

        /// <summary>
        /// Текущая выбранная ячейка в таблице команд (для удаления выбранной рамки)
        /// </summary>
        public static CellForRepaint current_cell;
    }
}