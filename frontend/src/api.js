import cover from './assets/images/1.jpeg'

const BoardsAPI = {
    boards: [
      { boardId: 1, boardName: "Small Village", boardImg: cover, boardDesc: 'A small map without too many obstacles. Start here, if you never played before.'},
      { boardId: 2, boardName: "Big Town", boardImg: cover, boardDesc: 'For intermediate players. This map will test your mettle' },
      { boardId: 3, boardName: "Huge Metropolis", boardImg: cover, boardDesc: 'For advanced players. Will destroy your confidence.'},
      { boardId: 4, boardName: "PUSSY DESTROYER", boardImg: cover, boardDesc: 'XXXX_xxxxXXXXXXX'},
      { boardId: 5, boardName: "GIT, I SAID GIT", boardImg: cover, boardDesc: 'GIT UP OFF MY LAWN ' },
      { boardId: 6, boardName: "Oy vey", boardImg: cover, boardDesc: 'wooweehhh this will really fuck you up' }
    ],
    all: function() { return this.boards},
    get: function(id) {
      const isBoard = p => p.boardId === id
      return this.boards.find(isBoard)
    }
  }
  
  export default BoardsAPI;