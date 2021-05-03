import React from "react";
import {
  Card,
  CardContent,
  Divider,
  makeStyles,
  Typography,
} from "@material-ui/core";

const useStyles = makeStyles({
  container: {
    textAlign: "center",
    width: "98%",
    margin: "1%",
  },
  title: {
    fontSize: 24,
  },
});
export default function Description() {
  const classes = useStyles();
  return (
    <div style={{ display: "flex", justifyContent: "center" }}>
      <Card className={classes.container}>
        <CardContent>
          <Typography color='textPrimary' className={classes.title}>
            Description
          </Typography>
          <Typography color='textSecondary'>Of my new React project</Typography>
          <Divider />
          <Typography variant='body2' component='p'>
            It will be used to display a custom videos from my
            CreativeCookies.API, first, I'll have to set this app similarly to
            Angular ClientApp already stored in CreativeCookies proj and then
            I'll have to set this client app to cooperate with IdentityServer.
          </Typography>
        </CardContent>
      </Card>
    </div>
  );
}
