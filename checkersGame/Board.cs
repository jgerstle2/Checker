using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers
{
    public partial class Board : Form
    {
        private enum Piece
        {
            EMPTY, WHITE_P, BLACK_P, WHITE_K, BLACK_K
        }

        private class Position
        {
            private Piece[,] position;
            public Position(int size)
            {
                position = new Piece[size, size];
                for (int row = 0; row < size; ++row)
                {
                    for (int col = 0; col < size; ++col)
                    {
                        int parity = (row + col) % 2;
                        if (parity == 0)
                        {
                            position[row, col] = Piece.EMPTY;
                        }
                        else
                        {
                            if (row < 3);
                        }}}}}}}
