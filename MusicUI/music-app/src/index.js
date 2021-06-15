import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import { makeStyles } from '@material-ui/core/styles';
import Paper from '@material-ui/core/Paper';
import Grid from '@material-ui/core/Grid';
import Sound from './soundViewModel';

class MatrixBoard extends React.Component{

  

  MatrixBoard(){

  }

  function GetSound(){
    fetch("localhost:44361/api/Music/AllSound", {
      "method": "GET"
    }).then(response => response.json()).then(data => Sound);
  }

  render(){
    return (
      <Grid container spacing = {4}>
        <Grid item xs = {4}>
          <Paper>{Sound.id}</Paper>
        </Grid>
        <Grid item xs = {4}>
          <Paper>Test 2</Paper>
        </Grid>
        <Grid item xs = {4}>
          <Paper>Test 3</Paper>
        </Grid>
        <Grid item xs = {4}>
          <Paper>Test 4</Paper>
        </Grid>
      </Grid>
    )
  }
}

ReactDOM.render(
  <MatrixBoard></MatrixBoard>,
  document.getElementById('root')
);



// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
