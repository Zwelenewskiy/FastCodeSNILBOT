using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace FastCodeSNILBot
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Генерирует случайный цвет
        /// </summary>
        private void GetRandomColor()
        {
            /*Color color;

            do
            {
                color = Color.FromArgb(
                       new Random(DateTime.Now.Millisecond).Next(0, 256),
                       new Random().Next(0, 256),
                       new Random().Next(0, 256)
                   );
            } while (Model.used_colors.Contains(color));

            return color;*/
        }

        /// <summary>
        /// Заполняет таблицу доступных команд текущего робота
        /// </summary>
        private void SetCommandsIcon()
        {
            for (int i = 0; i < Model.bots_commands_icons[Model.current_bot_type].Count; i++)
            {
                DGV_commands_icons.Rows[i].Cells[0].Value = Model.bots_commands_icons[Model.current_bot_type][i][0];
            }
        }

        private void ClearCommandsTable()
        {
            Model.commands_count = 0;
            BT_commands_count.Text = Model.commands_count.ToString();

            DGV_commands.Rows.Clear();
            Model.current_command_row = 0;
            Model.current_command_col = 0;

            DGV_commands.Rows.Add();
            DGV_commands.Rows[DGV_commands.RowCount - 1].Height = Model.COMMAND_ICON_HEIGHT;

            Model.command_cells_for_repaint.Clear();

            Model.selected_command_cell.Y = 0;
            Model.selected_command_cell.X = 0;

            DGV_commands.Refresh();
        }

        public static void SetDoubleBuffered(Control control)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                    BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                    null, 
                    control, 
                    new object[] { true }
                );
        }

        public MainForm()
        {
            InitializeComponent();

            Model.selected_command_cell.X = 0;
            Model.selected_command_cell.Y = 0;

            for (int i = 0; i <= Model.COMMANDS_COUNT; i++)
            {
                DGV_commands_icons.Rows.Add();
                DGV_commands_icons.Rows[DGV_commands_icons.RowCount - 1].Height = Model.COMMAND_ICON_HEIGHT;
            }

            SetCommandsIcon();

            BT_delete_command.Tag = 0;
            BT_clear_selecting.Tag = 1;
            BT_add_commnd.Tag = 2;
            BT_mashine_gun.Tag = 3;

            TSMI_humanoid_bot.Tag = 0;
            TSMI_collector_bot.Tag = 1;

            BT_mashine_gun.BackgroundImage = Properties.Resources.MashineGunSelected;

            for (int i = 0; i < Model.MAX_COLUMNS_COUNT; i++)
            {
                DGV_commands.Columns.Add(new DataGridViewImageColumn());
                DGV_commands.Columns[DGV_commands.ColumnCount - 1].Width = Model.COMMAND_ICON_HEIGHT;
            }

            DGV_commands.Rows.Add();
            DGV_commands.Rows[0].Height = Model.COMMAND_ICON_HEIGHT;
        }

        private void DGV_commands_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int row = Model.current_command_row;
            for (int i = 0; i < DGV_commands.ColumnCount; i++)
            {
                (DGV_commands.Rows[row].Cells[i] as DataGridViewImageCell).Value = Properties.Resources.BackGroundWhite;

                DGV_commands.Rows[row].Cells[i].Tag = new Model.CommandCellTag();
            }
        }

        private void DGV_commands_icons_DoubleClick(object sender, EventArgs e)
        {
            DGV_commands_icons_Click(sender, e);
        }

        private void DGV_commands_icons_Click(object sender, EventArgs e)
        {
            int icon_index = DGV_commands_icons.CurrentRow.Index;

            var icons = Model.bots_commands_icons[Model.current_bot_type].Select(n => n[1]).ToList();            

            for (int i = 0; i < DGV_commands_icons.RowCount; i++)
            {   
                if(i == icon_index)
                    DGV_commands_icons.Rows[i].Cells[0].Value = Model.bots_commands_icons[Model.current_bot_type][i][1];
                else
                    DGV_commands_icons.Rows[i].Cells[0].Value = Model.bots_commands_icons[Model.current_bot_type][i][0];
            }

            Model.current_command_icon_index = DGV_commands_icons.CurrentRow.Index;

            if (Model.current_operation_mode == Model.OperationMode.ReplaceCommand)
                return;

            if (Model.current_operation_mode == Model.OperationMode.MashineGun)
            {
                if (DGV_commands.ColumnCount < Model.MAX_COLUMNS_COUNT)
                {    
                    if (DGV_commands.RowCount == 0)
                    {
                        DGV_commands.Rows.Add();
                        DGV_commands.Rows[0].Height = Model.COMMAND_ICON_HEIGHT;
                    }
                }

                if (Model.current_command_col == Model.MAX_COLUMNS_COUNT - 1)
                {
                    DGV_commands.Rows[Model.current_command_row].Cells[Model.current_command_col].Value =
                        icons[Model.current_command_icon_index];

                    ((Model.CommandCellTag)DGV_commands.Rows[Model.current_command_row].Cells[Model.current_command_col].Tag).icon_index = Model.current_command_icon_index;
                    ((Model.CommandCellTag)DGV_commands.Rows[Model.current_command_row].Cells[Model.current_command_col].Tag).repainting_status = Model.RepaintingCellStatus.WithValue;

                    Model.current_command_col = 0;
                    Model.selected_command_cell.X = 0;

                    ((Model.CommandCellTag)DGV_commands.Rows[Model.current_command_row].Cells[Model.current_command_col].Tag).repainting_status = Model.RepaintingCellStatus.WithValue;

                    Model.current_command_row++;
                    Model.selected_command_cell.Y++;

                    if(Model.current_command_row == DGV_commands.RowCount)
                    {
                        DGV_commands.Rows.Add();
                        DGV_commands.Rows[DGV_commands.RowCount - 1].Height = Model.COMMAND_ICON_HEIGHT;

                        if (((Model.CommandCellTag)DGV_commands.Rows[Model.current_command_row].Cells[Model.current_command_col].Tag).repainting_status == Model.RepaintingCellStatus.WithoutValue)
                        {
                            Model.commands_count++;
                            BT_commands_count.Text = Model.commands_count.ToString();
                        }
                    }

                    int index = DGV_commands.RowCount - 1;

                    DGV_commands.ClearSelection();

                    DGV_commands.Rows[index].Selected = true;
                    DGV_commands.FirstDisplayedScrollingRowIndex = index;
                }
                else
                {
                    (DGV_commands.Rows[Model.current_command_row].Cells[Model.current_command_col] as DataGridViewImageCell).Value =
                        icons[Model.current_command_icon_index];

                    ((Model.CommandCellTag)DGV_commands.Rows[Model.current_command_row].Cells[Model.current_command_col].Tag).icon_index = Model.current_command_icon_index;
                    if (((Model.CommandCellTag)DGV_commands.Rows[Model.current_command_row].Cells[Model.current_command_col].Tag).repainting_status == Model.RepaintingCellStatus.WithoutValue)
                    {
                        Model.commands_count++;
                        BT_commands_count.Text = Model.commands_count.ToString();
                    }

                    ((Model.CommandCellTag)DGV_commands.Rows[Model.current_command_row].Cells[Model.current_command_col].Tag).repainting_status = Model.RepaintingCellStatus.WithValue;

                    Model.current_command_col++;
                    Model.selected_command_cell.X++;
                }
            }

            DGV_commands.Refresh();
        }

        private void BT_add_function_Click(object sender, EventArgs e)
        {
            if (Model.enabled_colors.Count == 0)
            {
                MessageBox.Show("Достигнуто максимальное количество возможных функций");
                return;
            }

            DGV_functions.Rows.Add();
            DGV_functions.Rows[DGV_functions.RowCount - 1].Height = 53;

            Color tmp = Model.enabled_colors[0];

            Model.function_cells_for_repaint.Add(new Model.CellForRepaint()
            {
                color = tmp
            });

            DGV_functions.Rows[DGV_functions.RowCount - 1].Cells[0].Tag = tmp;

            Model.enabled_colors.RemoveAt(0);

            DGV_functions.Rows[DGV_functions.RowCount - 1].Cells[0].Value = Properties.Resources.Func;

            DGV_functions.Refresh();
        }           

        private void DGV_commands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(((Model.CommandCellTag)DGV_commands.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag).icon_index + "");

            var cell = Model.command_cells_for_repaint.FirstOrDefault(c => c.collumn == e.ColumnIndex && c.row == e.RowIndex);

            switch (Model.current_operation_mode)
            {
                case Model.OperationMode.TemplatesSelecting:
                    if (((Model.CommandCellTag)DGV_commands.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag).repainting_status == Model.RepaintingCellStatus.WithValue)
                    {
                        if (cell != null)
                        {
                            if (cell.color != Model.current_select_color)
                            {
                                cell.color = Model.current_select_color;

                                int cell_index = Model.command_cells_for_repaint.FindIndex(c => c.collumn == e.ColumnIndex && c.row == e.RowIndex);
                                Model.command_cells_for_repaint[cell_index] = cell;
                            }
                        }
                        else
                        {
                            Model.command_cells_for_repaint.Add(new Model.CellForRepaint()
                            {
                                row = DGV_commands.CurrentCell.RowIndex,
                                collumn = DGV_commands.CurrentCell.ColumnIndex,
                                color = Model.current_select_color
                            });
                        }

                        Model.current_command_col = e.ColumnIndex;
                        Model.current_command_row = e.RowIndex;
                    }

                    break;

                case Model.OperationMode.SelectingRemove:
                    if (cell != null)
                        Model.command_cells_for_repaint.Remove(cell);

                    Model.current_command_col = e.ColumnIndex;
                    Model.current_command_row = e.RowIndex;

                    break;

                case Model.OperationMode.DeletingCommand:
                    if (cell != null)
                        Model.command_cells_for_repaint.Remove(cell);

                    DGV_commands.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.BackGroundWhite;
                    ((Model.CommandCellTag)DGV_commands.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag).repainting_status = Model.RepaintingCellStatus.WithoutValue;
                    ((Model.CommandCellTag)DGV_commands.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag).icon_index = -1;

                    if (Model.commands_count > 0)
                    {
                        Model.commands_count--;
                        BT_commands_count.Text = Model.commands_count + "";
                    }

                    Model.selected_command_cell.X = e.ColumnIndex;
                    Model.selected_command_cell.Y = e.RowIndex;

                    Model.current_command_col = e.ColumnIndex;
                    Model.current_command_row = e.RowIndex;

                    break;

                case Model.OperationMode.ReplaceCommand:
                    var selected_icons = Model.bots_commands_icons[Model.current_bot_type].Select(n => n[1]).ToList();

                    if (((Model.CommandCellTag)DGV_commands.Rows[Model.current_command_row].Cells[Model.current_command_col].Tag).repainting_status == Model.RepaintingCellStatus.WithoutValue)
                    {
                        Model.commands_count++;
                        BT_commands_count.Text = Model.commands_count.ToString();
                    }

                    Model.selected_command_cell.X = e.ColumnIndex;
                    Model.selected_command_cell.Y = e.RowIndex;

                    Model.current_command_col = e.ColumnIndex;
                    Model.current_command_row = e.RowIndex;

                    DGV_commands.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = selected_icons[Model.current_command_icon_index];

                    ((Model.CommandCellTag)DGV_commands.Rows[Model.current_command_row].Cells[Model.current_command_col].Tag).icon_index = Model.current_command_icon_index;
                    ((Model.CommandCellTag)DGV_commands.Rows[Model.current_command_row].Cells[Model.current_command_col].Tag).repainting_status = Model.RepaintingCellStatus.WithValue;

                    break;

                case Model.OperationMode.MashineGun:
                    Model.current_command_col = e.ColumnIndex;
                    Model.current_command_row = e.RowIndex;

                    break;
            }

            DGV_commands.Refresh();
        }

        private void DGV_functions_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            Model.CellForRepaint cell = Model.function_cells_for_repaint[e.RowIndex];

            e.PaintBackground(e.ClipBounds, true);
            e.PaintContent(e.ClipBounds);

            using (Brush text_brush = new SolidBrush(cell.color),
                background_brush = new SolidBrush(Color.FromArgb(166, 155, 17)),
                border_brush = new SolidBrush(Color.White))
            {
                using (Pen border_pen = new Pen(border_brush, Model.CELL_BORDER_WIDTH))
                {
                    e.Graphics.FillRectangle(background_brush, new Rectangle(
                        e.CellBounds.X + 2,
                        e.CellBounds.Y + 2,
                        e.CellBounds.Width - 4,
                        e.CellBounds.Height - 4
                    ));

                    if(e.RowIndex == Model.selected_color_cell_row)
                    {
                        e.Graphics.DrawRectangle(border_pen, new Rectangle(
                            e.CellBounds.X + 2,
                            e.CellBounds.Y + 2,
                            e.CellBounds.Width - 6,
                            e.CellBounds.Height - 6
                        ));
                    }

                    e.Graphics.DrawString("\nColor", e.CellStyle.Font,
                        text_brush, e.CellBounds.X + 2,
                        e.CellBounds.Y + 2, StringFormat.GenericDefault);
                }
            }

            e.Handled = true;
        }

        private void DGV_commands_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)  
        {
            var cell = Model.command_cells_for_repaint.FirstOrDefault(c => c.collumn == e.ColumnIndex && c.row == e.RowIndex);

            var not_selected_icons = Model.bots_commands_icons[Model.current_bot_type].Select(n => n[0]).ToList();
            int index = ((Model.CommandCellTag)DGV_commands.Rows[Model.current_command_row].Cells[Model.current_command_col].Tag).icon_index;

            e.PaintBackground(e.ClipBounds, true);
            e.PaintContent(e.ClipBounds);

            Color current_color = Color.White;

            if (e.RowIndex == Model.selected_command_cell.Y
                && e.ColumnIndex == Model.selected_command_cell.X)
            {
                if (index >= 0)
                {
                    e.Graphics.DrawImage(not_selected_icons[index], e.CellBounds);
                }
                else
                {
                    e.Graphics.DrawImage(Properties.Resources.BackGround_1, e.CellBounds);
                }
            }
            
            if (cell != null)
            {
                using (Brush border_brush = new SolidBrush(cell.color))
                {
                    using (Pen border_pen = new Pen(border_brush, 3))
                    {
                        e.Graphics.DrawRectangle(border_pen, new Rectangle(
                            e.CellBounds.X + 2,
                            e.CellBounds.Y + 2,
                            e.CellBounds.Width - 6,
                            e.CellBounds.Height - 6
                        )); 
                    }
                }
            }

            e.Handled = true;
        }

        private void DGV_functions_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Model.current_select_color = (Color)DGV_functions.Rows[e.RowIndex].Cells[0].Tag;

            Model.current_operation_mode = Model.OperationMode.TemplatesSelecting;

            BT_delete_command.BackgroundImage = Properties.Resources.DeleteButton;
            BT_clear_selecting.BackgroundImage = Properties.Resources.ClearButton;
            BT_add_commnd.BackgroundImage = Properties.Resources.AddCommandButton;
            BT_mashine_gun.BackgroundImage = Properties.Resources.MashineGun;
        }

        private void ProcessCommandButton(object sender, EventArgs e)
        {
            switch (Convert.ToInt32((sender as Button).Tag))
            {
                case 0:
                    Model.current_operation_mode = Model.OperationMode.DeletingCommand;

                    BT_delete_command.BackgroundImage = Properties.Resources.DeleteButtonSelected;
                    BT_clear_selecting.BackgroundImage = Properties.Resources.ClearButton;
                    BT_add_commnd.BackgroundImage = Properties.Resources.AddCommandButton;
                    BT_mashine_gun.BackgroundImage = Properties.Resources.MashineGun;
                    break;

                case 1:
                    BT_delete_command.BackgroundImage = Properties.Resources.DeleteButton;
                    BT_clear_selecting.BackgroundImage = Properties.Resources.ClearButtonSelected;
                    BT_add_commnd.BackgroundImage = Properties.Resources.AddCommandButton;
                    BT_mashine_gun.BackgroundImage = Properties.Resources.MashineGun;

                    Model.current_operation_mode = Model.OperationMode.SelectingRemove;
                    break;

                case 2:
                    BT_delete_command.BackgroundImage = Properties.Resources.DeleteButton;
                    BT_clear_selecting.BackgroundImage = Properties.Resources.ClearButton;
                    BT_add_commnd.BackgroundImage = Properties.Resources.AddCommandButtonSelected;
                    BT_mashine_gun.BackgroundImage = Properties.Resources.MashineGun;

                    Model.current_operation_mode = Model.OperationMode.ReplaceCommand;
                    break;

                case 3:
                    BT_delete_command.BackgroundImage = Properties.Resources.DeleteButton;
                    BT_clear_selecting.BackgroundImage = Properties.Resources.ClearButton;
                    BT_add_commnd.BackgroundImage = Properties.Resources.AddCommandButton;
                    BT_mashine_gun.BackgroundImage = Properties.Resources.MashineGunSelected;

                    Model.current_operation_mode = Model.OperationMode.MashineGun;
                    break;
            }

            Model.selected_color_cell_row = -1;
            DGV_functions.Refresh();
        }

        private void DGV_functions_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            Model.selected_color_cell_row = e.RowIndex;
        }

        private void BT_commands_count_Click(object sender, EventArgs e)
        {
            if (Model.current_operation_mode == Model.OperationMode.SelectingRemove)
            {
                ClearCommandsTable();
            }
        }

        private void TSMI_humanoid_bot_type_process(object sender, EventArgs e)
        {
            switch (Convert.ToInt32((sender as ToolStripMenuItem).Tag))
            {
                case 0:
                    Model.current_bot_type = Model.BotType.Humanoid;

                    TSMI_humanoid_bot.Checked = true;
                    TSMI_collector_bot.Checked = false;
                    break;
                case 1:
                    Model.current_bot_type = Model.BotType.Collector;

                    TSMI_humanoid_bot.Checked = false;
                    TSMI_collector_bot.Checked = true;
                    break;
            }

            SetCommandsIcon();
            Model.current_command_icon_index = 0;

            ClearCommandsTable();
        }

        private void DGV_commands_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            Model.selected_command_cell.X = e.ColumnIndex;
            Model.selected_command_cell.Y = e.RowIndex;

            Model.current_command_col = e.ColumnIndex;
            Model.current_command_row = e.RowIndex;
        }
    }
}
